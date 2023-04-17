using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BNState.Domain.Data;
using BNState.Domain.Models;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level3
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
      public Category3 Category3 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Category3s == null)
            {
                return NotFound();
            }

            var category3 = await _context.Category3s.FirstOrDefaultAsync(m => m.Id == id);

            if (category3 == null)
            {
                return NotFound();
            }
            else 
            {
                Category3 = category3;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.Category3s == null)
            {
                return NotFound();
            }
            var category3 = await _context.Category3s.FindAsync(id);

            if (category3 != null)
            {
                Category3 = category3;
                _context.Category3s.Remove(Category3);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
