using BNState.Domain.Dtos;
using BNState.Domain.Models;
using BNState.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Dashboard.Pages.Admin
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Dashboard")]

    public class SectionLevelsModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public SectionLevelsModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CategoryDto> Category { get; set; } = default!;
        public CategoryDto Category3 { get; set; } = default!;
        public IList<CategoryDto> AppointmentsList { get; set; } = default!;


        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category3 = await _context.Category3s.Include(x => x.Appointments).ThenInclude(x => x.Profile).FirstOrDefaultAsync(m => m.Id == id);
            
            var appoint = await _context.CategoryAppointments.Include(x => x.Profile).FirstOrDefaultAsync(x => x.Category3Id == id);
            if (appoint != null)
            {

                var mainoutput = new CategoryDto
                {
                    Id = category3.Id,
                    Title = category3.Title,
                    Fullname = appoint.Profile.Fullname ?? "",
                    Image = appoint.Profile.PhotoUrl ?? "/img/logo-1.png",
                    Email = appoint.Profile.Email ?? "",
                    PhoneNumbers = appoint.Profile.PhoneNumber ?? "",
                    Color = category3.Color,
                    Biography = appoint.Profile.Biography ?? "",
                    LogoUrl = category3.LogoUrl,
                    ShowStatus = category3.ShowStatus

                }; Category3 = mainoutput;
            }
            else
            {

                var mainoutput = new CategoryDto
                {
                    Id = category3.Id,
                    Title = category3.Title,
                    
                    Color = category3.Color,
                    LogoUrl = category3.LogoUrl,
                    ShowStatus = category3.ShowStatus
                }; Category3 = mainoutput;
            }
            

            if (Category3 == null)
            {
                return RedirectToPage("/");
            }

            var Category4s = _context.Category4s
                 .Include(x => x.Appointments)
                 .ThenInclude(x => x.Profile)
                 .Include(x => x.Category5s)
                 .Where(x => x.Category3Id == category3.Id)
                 .AsQueryable();
            //


            var output = Category4s
                .Select(d => new CategoryDto
                {
                    Id = d.Id,
                    Title = d.Title,
                    Fullname = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Profile.Fullname ?? "",
                    Color = d.Color
                });
            Category = await output.ToListAsync();
            if (category3.ShowStatus == Domain.Models.Enum.ShowStatus.Both || category3.ShowStatus == Domain.Models.Enum.ShowStatus.Profiles)
            {
                var xappontment = await _context.CategoryAppointments.Where(x => x.Category3Id == category3.Id).ToListAsync();
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
