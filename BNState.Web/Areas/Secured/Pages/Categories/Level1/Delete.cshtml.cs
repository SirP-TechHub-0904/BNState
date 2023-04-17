using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BNState.Domain.Data;
using BNState.Domain.Models;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level1
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
    public class DeleteModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public DeleteModel(BNState.Domain.Data.ApplicationDbContext context)
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

            var category1 = await _context.Category1s.FirstOrDefaultAsync(m => m.Id == id);

            if (category1 == null)
            {
                return NotFound();
            }
            else 
            {
                Category1 = category1;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.Category1s == null)
            {
                return NotFound();
            }
            var category1 = await _context.Category1s.FindAsync(id);

            if (category1 != null)
            {
                Category1 = category1;
                _context.Category1s.Remove(Category1);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
