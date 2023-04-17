using BNState.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Organogram.Level1
{
    public class NewLevelModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public NewLevelModel(BNState.Domain.Data.ApplicationDbContext context)
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

            var oglevel1 = await _context.OgLevel1s.FirstOrDefaultAsync(m => m.Id == id);
            if (oglevel1 == null)
            {
                return NotFound();
            }
            OgLevel1 = oglevel1;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            _context.OgLevel2s.Add(OgLevel2);

            try
            {
                await _context.SaveChangesAsync(); TempData["success"] = "Successful";

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

            return RedirectToPage("./Details", new {id = OgLevel2.OgLevel1Id});
        }

        private bool OgLevel1Exists(long id)
        {
            return (_context.OgLevel2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
