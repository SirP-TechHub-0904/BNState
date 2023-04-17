using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BNState.Domain.Data;
using BNState.Domain.Models;

namespace BNState.Web.Areas.Secured.Pages.Organogram.Level1
{
    public class CreateModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public CreateModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OgLevel1 OgLevel1 { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid || _context.OgLevel1s == null || OgLevel1 == null)
            //  {
            //      return Page();
            //  }
            var list = new List<string> { "bg-red", "bg-yellow", "bg-aqua", "bg-blue",
                    "bg-green", "bg-navy", "bg-teal", "bg-olive", "bg-lime", "bg-orange", "bg-fuchsia", "bg-purple",
                    "bg-maroon", "bg-gray" }; var random = new Random();
            OgLevel1.Color = list[random.Next(list.Count)];
            _context.OgLevel1s.Add(OgLevel1);
            await _context.SaveChangesAsync();
            TempData["success"] = "Successful";

            return RedirectToPage("./Index");
        }
    }
}
