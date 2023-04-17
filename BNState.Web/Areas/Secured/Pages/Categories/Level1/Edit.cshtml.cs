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

namespace BNState.Web.Areas.Secured.Pages.Categories.Level1
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
        public Category1 Category1 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Category1s == null)
            {
                return NotFound();
            }

            var category1 =  await _context.Category1s.FirstOrDefaultAsync(m => m.Id == id);
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
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            if (Category1.AddToDashboard == true)
            {
                Category1.OfficeCount = true;
            }
            _context.Attach(Category1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(); TempData["success"] = "Successful";

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
          return (_context.Category1s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
