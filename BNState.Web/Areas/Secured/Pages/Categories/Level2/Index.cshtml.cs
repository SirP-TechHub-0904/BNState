using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BNState.Domain.Data;
using BNState.Domain.Models;
using BNState.Domain.Dtos;
using System.Security.Cryptography;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level2
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
    public class IndexModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public IndexModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CategoryDto> Category2 { get; set; } = default!;
        public Category1 Category1 { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {

            if (id == null || _context.Category1s == null)
            {
                
                return RedirectToPage("/Result", new { error = "Invalid" });
            }

            var category1 = await _context.Category1s
                .Include(x => x.Appointments)
                     .ThenInclude(x => x.Profile)
                     .Include(x => x.Category2s)
                     .ThenInclude(x => x.Appointments)
                      .Include(x => x.Category2s)
                     .ThenInclude(x => x.Category3s)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (category1 == null)
            {
                return NotFound();
            }
            Category1 = category1;
            if (_context.Category2s != null)
            {
                var Category2s = _context.Category2s
                     .Include(x => x.Appointments)
                     .ThenInclude(x => x.Profile)
                     .Include(x => x.Category3s)
                     .Where(x=>x.Category1Id == id)
                     .AsQueryable();

                var output = Category2s
                   .Select(d => new CategoryDto
                   {
                       Id = d.Id,
                       Title = d.Title,
                       Description = d.Description,
                       Email = d.Email,
                       Address = d.Address,
                       PhoneNumbers = d.PhoneNumbers,
                       Website = d.Website,
                       Code = d.Code,
                       SubCategoryCount = d.Category3s.Count(),
                       Fullname = d.Appointments.AsQueryable().OrderBy(x=>x.Order).FirstOrDefault().Profile.Fullname ?? "",
                       Position = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Position ?? "",
                       EndOfAppointment = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().EndOfAppointment.ToString("yyyy") ?? "----",
                       StartOfAppointment = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().StartOfAppointment.ToString("yyyy") ?? "----",
        UserId = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Profile.Id ?? "",
                   });
                Category2 = await output.ToListAsync();

                

            }
            return Page();
        }
    }
}
