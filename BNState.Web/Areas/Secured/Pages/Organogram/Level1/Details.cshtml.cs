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
    public class DetailsModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public DetailsModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public OgLevel1 OgLevel1 { get; set; } = default!; 

        public List<AppointmentDto> AppointmentDtos { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.OgLevel1s == null)
            {
                return NotFound();
            }

            var oglevel1 = await _context.OgLevel1s
                .Include(x => x.Appointments)
                     .ThenInclude(x => x.Profile)
                     .Include(x => x.OgLevel2s)
                     .ThenInclude(x=>x.Appointments)
                      .Include(x => x.OgLevel2s)
                     .ThenInclude(x=>x.OgLevel3s)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (oglevel1 == null)
            {
                return NotFound();
            }
            else 
            {
                OgLevel1 = oglevel1;
            }

            //var appointlist = _context.OgAppointments.Include(x=>x.Profile).Where(x => x.OgLevel1Id == id).OrderBy(x=>x.Order).AsQueryable();
            //var output = appointlist
            //       .Select(d => new AppointmentDto
            //       {
            //           Id = d.Id,
            //           Fullname = d.Profile.Fullname ?? "",
            //           Position = d.Position ?? "",
            //           EndOfAppointment = d.EndOfAppointment.ToString("yyyy") ?? "----",
            //           StartOfAppointment = d.StartOfAppointment.ToString("yyyy") ?? "----",

            //       });
            //AppointmentDtos = output.ToList();

            return Page();
        }
        [BindProperty]
        public long mid { get; set; }
        public async Task<IActionResult> OnPostDelete(long? id)
        {
            if (id == null)
            {
                TempData["error"] = "unable to delete";
                return RedirectToPage("./Details", new { id = mid });
            }
            var xpage = await _context.OgAppointments.FindAsync(id);

            if (xpage != null)
            { 
                _context.OgAppointments.Remove(xpage);
                await _context.SaveChangesAsync();
            }
            TempData["success"] = "Successful";

            return RedirectToPage("./Details", new { id = mid});
        }

        public async Task<IActionResult> OnPostDeleteLevel(long? id)
        {
            if (id == null)
            {
                TempData["error"] = "unable to delete";
                return RedirectToPage("./Details", new { id = mid });
            }
            var xpage = await _context.OgLevel2s.FindAsync(id);

            if (xpage != null)
            {
                if(xpage.OgLevel3s != null)
                {
                    TempData["error"] = "Have casecading data";
                    return RedirectToPage("./Details", new { id = mid });
                }
                if (xpage.Appointments != null)
                {
                    TempData["error"] = "Have casecading data";
                    return RedirectToPage("./Details", new { id = mid });
                }
                _context.OgLevel2s.Remove(xpage);
                await _context.SaveChangesAsync();
                TempData["success"] = "Successful";
            }
            
            return RedirectToPage("./Details", new { id = mid });
        }
    }
}
