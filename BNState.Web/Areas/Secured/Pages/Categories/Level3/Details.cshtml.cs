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
using BNState.Domain.Services.AWS;
using Microsoft.AspNetCore.Identity;
using BNState.Domain.Dtos.AwsDtos;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level3
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
    public class DetailsModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;
        private readonly IConfiguration _config;
        private readonly IStorageService _storageService;

        public DetailsModel(BNState.Domain.Data.ApplicationDbContext context, UserManager<Profile> userManager, IConfiguration config, IStorageService storageService)
        {
            _context = context;
            _userManager = userManager;
            _config = config;
            _storageService = storageService;
        }
        [BindProperty]
        public Category3 Category3 { get; set; } = default!;

        public List<AppointmentDto> AppointmentDtos { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Category2s == null)
            {
                return NotFound();
            }

            var category3 = await _context.Category3s
                .Include(x => x.Category2)
                .Include(x => x.Appointments)
                     .ThenInclude(x => x.Profile)
                     .Include(x => x.Category4s)
                     .ThenInclude(x => x.Appointments)
                      .Include(x => x.Category4s)
                     .ThenInclude(x => x.Category5s)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (category3 == null)
            {
                return NotFound();
            }
            else
            {
                Category3 = category3;
            }

            var appointlist = _context.CategoryAppointments.Include(x => x.Profile).Where(x => x.Category3Id == id).OrderBy(x => x.Order).AsQueryable();
            var output = appointlist
                   .Select(d => new AppointmentDto
                   {
                       Id = d.Id,
                       Fullname = d.Profile.Fullname ?? "",
                       Position = d.Position ?? "",
                       EndOfAppointment = d.EndOfAppointment.ToString("yyyy") ?? "----",
                       StartOfAppointment = d.StartOfAppointment.ToString("yyyy") ?? "----",
                       UserId = d.ProfileId,
                       Photo = d.Profile.PhotoUrl
                   });
            AppointmentDtos = output.ToList();

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
            var xpage = await _context.CategoryAppointments.FindAsync(id);

            if (xpage != null)
            {
                _context.CategoryAppointments.Remove(xpage);
                await _context.SaveChangesAsync();
            }
            TempData["success"] = "Successful";

            return RedirectToPage("./Details", new { id = mid });
        }

        public async Task<IActionResult> OnPostDeleteLevel(long? id)
        {
            if (id == null)
            {
                TempData["error"] = "unable to delete";
                return RedirectToPage("./Details", new { id = mid });
            }
            var xpage = await _context.Category4s.Include(x => x.Category5s).Include(x => x.Appointments).FirstOrDefaultAsync(x=>x.Id == id);

            if (xpage != null)
            {
                if (xpage.Category5s.Count() > 0)
                {
                    TempData["error"] = "Have casecading data";
                    return RedirectToPage("./Details", new { id = mid });
                }
                if (xpage.Appointments.Count() > 0)
                {
                    TempData["error"] = "Have casecading data";
                    return RedirectToPage("./Details", new { id = mid });
                }
                _context.Category4s.Remove(xpage);
                await _context.SaveChangesAsync();
                TempData["success"] = "Successful";
            }

            return RedirectToPage("./Details", new { id = mid });
        }

        public async Task<IActionResult> OnPostRefreshColor(long? id)
        {
            if (id == null)
            {
                TempData["error"] = "unable to delete";
                return NotFound();
            }
            var xpage = await _context.Category4s.FindAsync(id);
            var list = new List<string> { "bg-red", "bg-yellow", "bg-aqua", "bg-blue",
                    "bg-green", "bg-navy", "bg-teal", "bg-olive", "bg-lime", "bg-orange", "bg-fuchsia", "bg-purple",
                    "bg-maroon", "bg-gray" }; var random = new Random();
            xpage.Color = list[random.Next(list.Count)];
            _context.Attach(xpage).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            TempData["success"] = "Successful";


            return RedirectToPage("./Details", new { id = xpage.Category3Id });
        }
        [BindProperty]
        public IFormFile? xfile { get; set; }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                TempData["error"] = "unable to delete";
                return RedirectToPage("./Details", new { id = mid });
            }
            var xpage = await _context.Category3s.FindAsync(id);

            if (xpage != null)
            {
                if (xfile != null)
                {

                    try
                    {
                        // Process file
                        await using var memoryStream = new MemoryStream();
                        await xfile.CopyToAsync(memoryStream);

                        var fileExt = Path.GetExtension(xfile.FileName);
                        var docName = $"{Guid.NewGuid()}{fileExt}";
                        // call server

                        var s3Obj = new Domain.Dtos.AwsDtos.S3Object()
                        {
                            BucketName = "benuestate",
                            InputStream = memoryStream,
                            Name = docName
                        };

                        var cred = new AwsCredentials()
                        {
                            AccessKey = _config["AwsConfiguration:AWSAccessKey"],
                            SecretKey = _config["AwsConfiguration:AWSSecretKey"]
                        };

                        var xresult = await _storageService.UploadFileReturnUrlAsync(s3Obj, cred, "");
                        //  
                        if (xresult.Message.Contains("200"))
                        {
                            xpage.LogoUrl = xresult.Url;
                            xpage.Key = xresult.Key;
                        }
                        else
                        {
                            TempData["error"] = "unable to upload image";
                            //return Page();
                        }
                    }
                    catch (Exception c)
                    {

                    }
                }
                xpage.Description = Category3.Description;
                xpage.ShowStatus = Category3.ShowStatus;

                _context.Attach(xpage).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            TempData["success"] = "Successful";

            return RedirectToPage("./Details", new { id = xpage.Id });
        }
    }
}
