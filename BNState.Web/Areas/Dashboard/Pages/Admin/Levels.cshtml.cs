using BNState.Domain.Dtos;
using BNState.Domain.Models;
using BNState.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Dashboard.Pages.Admin
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Dashboard")]

    public class LevelsModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public LevelsModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CategoryDto> Category { get; set; } = default!;
        public IList<CategoryDto> AppointmentsList { get; set; } = default!;
        public CategoryDto Category2 { get; set; } = default!;


        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category2 = await _context.Category2s.Include(x=>x.Appointments).ThenInclude(x=>x.Profile).FirstOrDefaultAsync(m => m.Id == id);
            var appoint = await _context.CategoryAppointments.Include(x => x.Profile).FirstOrDefaultAsync(x => x.Category2Id == id);

            if (appoint != null)
            {

                var mainoutput = new CategoryDto
                {
                    Id = category2.Id,
                    Title = category2.Title,
                    Fullname = appoint.Profile.Fullname ?? "",
                    Image = appoint.Profile.PhotoUrl ?? "/img/logo-1.png",
                    Email = appoint.Profile.Email ?? "",
                    PhoneNumbers = appoint.Profile.PhoneNumber ?? "",
                    Color = category2.Color,
                    Biography = appoint.Profile.Biography ?? "",
                    ActiviatePortal = category2.ActiviatePortal,
                    LogoUrl = category2.LogoUrl,
                    ShowStatus = category2.ShowStatus

                }; Category2 = mainoutput;
            }
            else
            {

                var mainoutput = new CategoryDto
                {
                    Id = category2.Id,
                    Title = category2.Title,

                    Color = category2.Color,
                    LogoUrl = category2.LogoUrl,
                    ShowStatus = category2.ShowStatus
                }; Category2 = mainoutput;
            }
             
            if(category2.ShowStatus == Domain.Models.Enum.ShowStatus.Both || category2.ShowStatus == Domain.Models.Enum.ShowStatus.Profiles)
            {
                var xappontment = await _context.CategoryAppointments.Where(x=>x.Category2Id == category2.Id).ToListAsync();
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


            if (Category2 == null)
            {
                return RedirectToPage("/");
            }

            var Category3s = _context.Category3s
                 .Include(x => x.Appointments)
                 .ThenInclude(x => x.Profile)
                 .Include(x => x.Category4s)
                 .Where(x => x.Category2Id == category2.Id)
                 .AsQueryable();
            //


            var output = Category3s
                .Select(d => new CategoryDto
                {
                    Id = d.Id,
                    Title = d.Title,
                    Fullname = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Profile.Fullname ?? "",
                    Color = d.Color
                });
            Category = await output.ToListAsync();

            return Page();
        }
    }
}
