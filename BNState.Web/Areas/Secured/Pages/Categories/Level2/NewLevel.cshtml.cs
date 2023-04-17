using BNState.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level2
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
        public Category2 Category2 { get; set; } = default!;
        [BindProperty]
        public Category3 Category3 { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category2 = await _context.Category2s.Include(x=>x.Category1).FirstOrDefaultAsync(m => m.Id == id);
            if (category2 == null)
            {
                return NotFound();
            }
            Category2 = category2;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var list = new List<string> { "bg-red", "bg-yellow", "bg-aqua", "bg-blue",
                    "bg-green", "bg-navy", "bg-teal", "bg-olive", "bg-lime", "bg-orange", "bg-fuchsia", "bg-purple",
                    "bg-maroon", "bg-gray" }; var random = new Random();
            Category3.Color = list[random.Next(list.Count)];
            Category3.Order = 0;
            if (Category3.AddToDashboard == true)
            {
                Category3.OfficeCount = true;
            }
            _context.Category3s.Add(Category3);

            try
            {
                await _context.SaveChangesAsync();
                TempData["success"] = "Successful";

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Category1Exists(Category2.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Details", new {id = Category3.Category2Id});
        }

        private bool Category1Exists(long id)
        {
            return (_context.Category2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
