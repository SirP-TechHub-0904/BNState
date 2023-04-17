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

namespace BNState.Web.Areas.Secured.Pages.Organogram.Level1
{
    public class IndexModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public IndexModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<LevelDto> OgLevel1 { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.OgLevel1s != null)
            {
                var OgLevel1s = _context.OgLevel1s
                     .Include(x => x.Appointments)
                     .ThenInclude(x => x.Profile)
                     .Include(x => x.OgLevel2s)
                     .AsQueryable();

                var output = OgLevel1s
                   .Select(d => new LevelDto
                   {
                       Id = d.Id,
                       Title = d.Title,
                       Description = d.Description,
                       OgLevel2s = d.OgLevel2s.Count(),
                       Fullname = d.Appointments.AsQueryable().OrderBy(x=>x.Order).FirstOrDefault().Profile.Fullname ?? "",
                       Position = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Position ?? "",
                       EndOfAppointment = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().EndOfAppointment.ToString("yyyy") ?? "----",
                       StartOfAppointment = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().StartOfAppointment.ToString("yyyy") ?? "----",
        UserId = d.Appointments.AsQueryable().OrderBy(x => x.Order).FirstOrDefault().Profile.Id ?? "",
                   });
                OgLevel1 = await output.ToListAsync();

            }
        }
    }
}
