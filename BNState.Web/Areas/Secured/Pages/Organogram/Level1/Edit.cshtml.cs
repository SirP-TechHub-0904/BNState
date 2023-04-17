using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BNState.Domain.Data;
using BNState.Domain.Models;

namespace BNState.Web.Areas.Secured.Pages.Organogram.Level1
{
    public class EditModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public EditModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OgLevel1 OgLevel1 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.OgLevel1s == null)
            {
                return NotFound();
            }

            var oglevel1 =  await _context.OgLevel1s.FirstOrDefaultAsync(m => m.Id == id);
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
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OgLevel1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(); TempData["success"] = "Successful";

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OgLevel1Exists(OgLevel1.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OgLevel1Exists(long id)
        {
          return (_context.OgLevel1s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
