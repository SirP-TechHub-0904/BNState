using BNState.Domain.Dtos;
using BNState.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;

namespace BNState.Web.Areas.Dashboard.Pages.Admin
{

    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Dashboard")]

    public class IndexModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public IndexModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<DashboardDto> Dashboard { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category1s != null)
            {
                var Category1s = _context.Category1s
                     .Include(x => x.Appointments)
                     .ThenInclude(x => x.Profile)
                     .Include(x => x.Category2s).Where(x => x.AddToDashboard == true)
                     .AsQueryable();

                var output = Category1s
                   .Select(d => new DashboardDto
                   {
                       Id = d.Id,
                       Title = d.Title,
                       UserNumbers = d.Appointments.Count(),
                       OfficeNumbers = d.Category2s.Count(),
                       UserCount = d.UserCount,
                       OfficeCount = d.OfficeCount,
                       Color = d.Color,
                       ModelString = "Level1",
                       DashboardOrder = d.DashboardOrder
                   });
                var Category2s = _context.Category2s
                    .Include(x => x.Appointments)
                    .ThenInclude(x => x.Profile)
                    .Include(x => x.Category3s).Where(x => x.AddToDashboard == true)
                    .AsQueryable();

                var output2 = Category2s
                   .Select(d => new DashboardDto
                   {
                       Id = d.Id,
                       Title = d.Title,
                       UserNumbers = d.Appointments.Count(),
                       OfficeNumbers = d.Category3s.Count(),
                       UserCount = d.UserCount,
                       OfficeCount = d.OfficeCount,
                       Color = d.Color,
                       ModelString = "Level2",
                       DashboardOrder = d.DashboardOrder
                   });
                //
                var Category3s = _context.Category3s
                   .Include(x => x.Appointments)
                   .ThenInclude(x => x.Profile)
                   .Include(x => x.Category4s).Where(x => x.AddToDashboard == true)
                   .AsQueryable();
                var output3 = Category3s
                  .Select(d => new DashboardDto
                  {
                      Id = d.Id,
                      Title = d.Title,
                      UserNumbers = d.Appointments.Count(),
                      OfficeNumbers = d.Category4s.Count(),
                      UserCount = d.UserCount,
                      OfficeCount = d.OfficeCount,
                      Color = d.Color,
                      ModelString = "Level3",
                      DashboardOrder = d.DashboardOrder
                  });

                Dashboard = output.Concat(output3).Concat(output2).OrderBy(x => x.DashboardOrder).AsQueryable();

            }
        }

    }
}


