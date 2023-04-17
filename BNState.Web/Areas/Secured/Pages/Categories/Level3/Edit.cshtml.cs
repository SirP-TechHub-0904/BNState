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

namespace BNState.Web.Areas.Secured.Pages.Categories.Level3
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
    public class EditModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public EditModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Category3 Category3 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Category3s == null)
            {
                return NotFound();
            }

            var category3 =  await _context.Category3s.FirstOrDefaultAsync(m => m.Id == id);
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
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            if (Category3.AddToDashboard == true)
            {
                Category3.OfficeCount = true;
            }
            _context.Attach(Category3).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(); TempData["success"] = "Successful";

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

            return RedirectToPage("./Index", new {id = Category3.Category2Id});
        }

        private bool Category1Exists(long id)
        {
          return (_context.Category2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
