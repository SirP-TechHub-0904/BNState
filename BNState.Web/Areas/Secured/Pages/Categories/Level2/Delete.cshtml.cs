using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BNState.Domain.Data;
using BNState.Domain.Models;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level2
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
      public Category2 Category2 { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Category2s == null)
            {
                return NotFound();
            }

            var category2 = await _context.Category2s.FirstOrDefaultAsync(m => m.Id == id);

            if (category2 == null)
            {
                return NotFound();
            }
            else 
            {
                Category2 = category2;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.Category2s == null)
            {
                return NotFound();
            }
            var category2 = await _context.Category2s.FindAsync(id);

            if (category2 != null)
            {
                Category2 = category2;
                _context.Category2s.Remove(Category2);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
