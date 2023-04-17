using BNState.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level3
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
    public class NewLevelModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public NewLevelModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Category3 Category3 { get; set; } = default!;
        [BindProperty]
        public Category4 Category4 { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category3 = await _context.Category3s.Include(x=>x.Category2).FirstOrDefaultAsync(m => m.Id == id);
            if (category3 == null)
            {
                return NotFound();
            }
            Category3 = category3;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var list = new List<string> { "bg-red", "bg-yellow", "bg-aqua", "bg-blue",
                    "bg-green", "bg-navy", "bg-teal", "bg-olive", "bg-lime", "bg-orange", "bg-fuchsia", "bg-purple",
                    "bg-maroon", "bg-gray" }; var random = new Random();
            Category4.Color = list[random.Next(list.Count)];
            Category4.Order = 0;
            if (Category4.AddToDashboard == true)
            {
                Category4.OfficeCount = true;
            }
            _context.Category4s.Add(Category4);

            try
            {
                await _context.SaveChangesAsync();
                TempData["success"] = "Successful";

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Category1Exists(Category3.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Details", new {id = Category4.Category3Id});
        }

        private bool Category1Exists(long id)
        {
            return (_context.Category2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
