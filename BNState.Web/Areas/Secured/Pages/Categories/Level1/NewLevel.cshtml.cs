using BNState.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level1
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
        public Category1 Category1 { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category1 = await _context.Category1s.FirstOrDefaultAsync(m => m.Id == id);
            if (category1 == null)
            {
                return NotFound();
            }
            Category1 = category1;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var list = new List<string> { "bg-red", "bg-yellow", "bg-aqua", "bg-blue",
                    "bg-green", "bg-navy", "bg-teal", "bg-olive", "bg-lime", "bg-orange", "bg-fuchsia", "bg-purple",
                    "bg-maroon", "bg-gray" }; var random = new Random();
            Category2.Color = list[random.Next(list.Count)];
            Category2.Order = 0;
            if (Category2.AddToDashboard == true)
            {
                Category2.OfficeCount = true;
            }
            _context.Category2s.Add(Category2);

            try
            {
                await _context.SaveChangesAsync(); TempData["success"] = "Successful";

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

            return RedirectToPage("./Details", new {id = Category2.Category1Id});
        }

        private bool Category1Exists(long id)
        {
            return (_context.Category2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
