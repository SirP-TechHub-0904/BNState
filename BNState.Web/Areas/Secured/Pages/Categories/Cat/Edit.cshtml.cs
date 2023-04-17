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

namespace BNState.Web.Areas.Secured.Pages.Categories.Cat
{
    public class EditModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public EditModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Category1 Category1 { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category1 = await _context.Category1s.FirstOrDefaultAsync(m => m.Id == id);

            if (Category1 == null)
            {
                return NotFound();
            }
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

            _context.Attach(Category1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Category1Exists(Category1.Id))
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

        private bool Category1Exists(long id)
        {
            return _context.Category1s.Any(e => e.Id == id);
        }
    }
}
