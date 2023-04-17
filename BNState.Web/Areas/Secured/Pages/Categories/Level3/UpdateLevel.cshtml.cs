using BNState.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level3
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
        public Category3 Category3 { get; set; } = default!;
        [BindProperty]
        public Category4 Category4 { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(long? id, long? mid)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category3 = await _context.Category3s.Include(x => x.Category2).Include(x=>x.Category4s).FirstOrDefaultAsync(m => m.Id == id);
            if (category3 == null)
            {
                return NotFound();
            }
            Category3 = category3;

            if (id == null)
            {
                return NotFound();
            }

            var category4 = await _context.Category4s.FirstOrDefaultAsync(m => m.Id == mid);
            if (category4 == null)
            {
                return NotFound();
            }
            Category4 = category4;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (Category4.AddToDashboard == true)
            {
                Category4.OfficeCount = true;
            }
            _context.Attach(Category4).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Category1Exists(Category4.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Details", new { id = Category4.Category3Id });
        }

        private bool Category1Exists(long id)
        {
            return (_context.Category2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
