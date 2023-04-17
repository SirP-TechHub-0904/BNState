using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BNState.Domain.Data;
using BNState.Domain.Models;

namespace BNState.Web.Areas.Secured.Pages.Categories.Cat
{
    public class DetailsModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public DetailsModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
