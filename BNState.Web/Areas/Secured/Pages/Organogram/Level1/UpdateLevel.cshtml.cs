using BNState.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Organogram.Level1
{
    public class UpdateLevelModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public UpdateLevelModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OgLevel2 OgLevel2 { get; set; } = default!;
        [BindProperty]
        public OgLevel1 OgLevel1 { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oglevel2 = await _context.OgLevel2s.Include(x=>x.OgLevel1).FirstOrDefaultAsync(m => m.Id == id);
            if (oglevel2 == null)
            {
                return NotFound();
            }
            OgLevel2 = oglevel2;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            _context.Attach(OgLevel2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OgLevel1Exists(OgLevel2.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Details", new { id = OgLevel1.Id });
        }

        private bool OgLevel1Exists(long id)
        {
            return (_context.OgLevel2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
