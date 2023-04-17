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

namespace BNState.Web.Areas.Secured.Pages.Categories.Level3
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
    public class IndexModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public IndexModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CategoryDto> Category3 { get; set; } = default!;
        public Category2 Category2 { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {

            if (id == null || _context.Category3s == null)
            {
                
                return RedirectToPage("/Result", new { error = "Invalid" });
            }

            var category2 = await _context.Category2s
                .Include(x => x.Appointments)
                     .ThenInclude(x => x.Profile)
                     .Include(x => x.Category3s)
                     .ThenInclude(x => x.Appointments)
                      .Include(x => x.Category3s)
                     .ThenInclude(x => x.Category4s)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (category2 == null)
            {
                return NotFound();
            }
            Category2 = category2;
            if (_context.Category3s != null)
            {
                var Category3s = _context.Category3s
                     .Include(x => x.Appointments)
                     .ThenInclude(x => x.Profile)
                     .Include(x => x.Category4s)
                     .Where(x=>x.Category2Id == id)
                     .AsQueryable();

                var output = Category3s
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
                       SubCategoryCount = d.Category4s.Count(),
                       Fullname = d.Appointments.AsQueryable().OrderBy(x=>x.Order).FirstOrDefault().Profile.Fullname ?? "",
                       Position = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Position ?? "",
                       EndOfAppointment = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().EndOfAppointment.ToString("yyyy") ?? "----",
                       StartOfAppointment = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().StartOfAppointment.ToString("yyyy") ?? "----",
        UserId = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Profile.Id ?? "",
                   });
                Category3 = await output.ToListAsync();

                

            }
            return Page();
        }
    }
}
