using BNState.Domain.Dtos;
using BNState.Domain.Models;
using BNState.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Dashboard.Pages.Admin
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Dashboard")]

    public class SectionModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public SectionModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CategoryDto> Category { get; set; } = default!;
        public Category1 Category1 { get; set; } = default!;
        public IList<CategoryDto> AppointmentsList { get; set; } = default!;


        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category1 = await _context.Category1s.FirstOrDefaultAsync(m => m.Id == id);

            
            if (Category1 == null)
            {
                return RedirectToPage("/");
            }

            var Category2s = _context.Category2s
                 .Include(x => x.Appointments)
                 .ThenInclude(x => x.Profile)
                 .Include(x => x.Category3s)
                 .Where(x => x.Category1Id == Category1.Id)
                 .AsQueryable();
            //


            var output = Category2s
                .Select(d => new CategoryDto
                {
                    Id = d.Id,
                    Title = d.Title,
                    Fullname = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Profile.Fullname ?? "",
                    Color = d.Color,
                    LogoUrl = d.LogoUrl,
                    ShowStatus = d.ShowStatus
                });
            Category = await output.ToListAsync();
            if (Category1.ShowStatus == Domain.Models.Enum.ShowStatus.Both || Category1.ShowStatus == Domain.Models.Enum.ShowStatus.Profiles)
            {
                var xappontment = await _context.CategoryAppointments.Include(x=>x.Profile).Where(x => x.Category1Id == Category1.Id).ToListAsync();
                var xoutput = xappontment
              .Select(d => new CategoryDto
              {
                  Id = d.Id,
                  Title = d.Position,
                  Fullname = d.Profile.Fullname ?? "",
                  Color = MainServices.SelectColor(),
                  Image = d.Profile.PhotoUrl ?? "",
                  UserId = d.Profile.Id
              });
                AppointmentsList = xoutput.ToList();
            }

            return Page();
        }
    }
}
