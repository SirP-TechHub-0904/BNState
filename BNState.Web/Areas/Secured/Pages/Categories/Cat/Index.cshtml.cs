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
    public class IndexModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public IndexModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category1> Category1 { get; set; }

        public async Task OnGetAsync()
        {
            Category1 = await _context.Category1s.ToListAsync();
            var c1 = await _context.Category1s.ToListAsync();
            foreach (var x in c1)
            {
                x.OfficeCount = true;
                _context.Attach(x).State = EntityState.Modified;
            }
            var c2 = await _context.Category2s.ToListAsync();
            foreach (var x in c2)
            {
                x.OfficeCount = true;
                _context.Attach(x).State = EntityState.Modified;
            }
            var c3 = await _context.Category3s.ToListAsync();
            foreach (var x in c3)
            {
                x.OfficeCount = true;
                _context.Attach(x).State = EntityState.Modified;
            }
            var c4 = await _context.Category4s.ToListAsync();
            foreach (var x in c1)
            {
                x.OfficeCount = true;
                _context.Attach(x).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}
