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

namespace BNState.Web.Areas.Secured.Pages.Categories.Level1
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
    public class IndexModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public IndexModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CategoryDto> Category1 { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category1s != null)
            {
                var Category1s = _context.Category1s
                     .Include(x => x.Appointments)
                     .ThenInclude(x => x.Profile)
                     .Include(x => x.Category2s)
                     .AsQueryable();

                var output = Category1s
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
                       SubCategoryCount = d.Category2s.Count(),
                       Fullname = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Profile.Fullname ?? "",
                       Position = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Position ?? "",
                       EndOfAppointment = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().EndOfAppointment.ToString("yyyy") ?? "----",
                       StartOfAppointment = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().StartOfAppointment.ToString("yyyy") ?? "----",
                       UserId = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Profile.Id ?? "",
                       Color = d.Color
                   });
                Category1 = await output.ToListAsync();

            }
        }
        public async Task<IActionResult> OnPostRefreshColor(long? id)
        {
            if (id == null)
            {
                TempData["error"] = "unable to delete";
                return NotFound();
            }
            var xpage = await _context.Category1s.FindAsync(id);
            var list = new List<string> { "bg-red", "bg-yellow", "bg-aqua", "bg-blue",
                    "bg-green", "bg-navy", "bg-teal", "bg-olive", "bg-lime", "bg-orange", "bg-fuchsia", "bg-purple",
                    "bg-maroon", "bg-gray" }; var random = new Random();
            xpage.Color = list[random.Next(list.Count)];
            _context.Attach(xpage).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            TempData["success"] = "Successful";


            return RedirectToPage("./Index");
        }


    }
}
