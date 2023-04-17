using BNState.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level2
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
    public class UpdateLevelModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public UpdateLevelModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Category2 Category2 { get; set; } = default!;
        [BindProperty]
        public Category3 Category3 { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(long? id, long? mid)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category2 = await _context.Category2s.Include(x => x.Category1).Include(x=>x.Category3s).FirstOrDefaultAsync(m => m.Id == id);
            if (category2 == null)
            {
                return NotFound();
            }
            Category2 = category2;

            if (id == null)
            {
                return NotFound();
            }

            var category3 = await _context.Category3s.FirstOrDefaultAsync(m => m.Id == mid);
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
            if (Category3.AddToDashboard == true)
            {
                Category3.OfficeCount = true;
            }
            _context.Attach(Category3).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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

            return RedirectToPage("./Details", new { id = Category3.Category2Id });
        }

        private bool Category1Exists(long id)
        {
            return (_context.Category2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
