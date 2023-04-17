using BNState.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Organogram.Level1
{
    public class NewOfficialModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;

        public NewOfficialModel(BNState.Domain.Data.ApplicationDbContext context, UserManager<Profile> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return RedirectToPage("/Result", new { error = "Invalid Data" });
            }

            OgLevel1 = await _context.OgLevel1s.FirstOrDefaultAsync(m => m.Id == id);
            if (OgLevel1 == null)
            {
                return RedirectToPage("/Result", new { error = "Invalid Level" });
            }

            var list = _context.Users.Where(x => x.Email != "admin@abia.com").OrderBy(x => x.Title).AsQueryable();
            ViewData["ProfileId"] = new SelectList(list, "Id", "Fullname");

            RouteId = id;
            return Page();
        }

        [BindProperty]
        public OgAppointment OgAppointment { get; set; } = default!;
        public OgLevel1 OgLevel1 { get; set; } = default!;

        [BindProperty]
        public long? RouteId { get; set; }

        [BindProperty]
        public bool NewAccount { get; set; }

        [BindProperty]
        public Profile Profile { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (String.IsNullOrEmpty(Profile.SurName))
            {
                var checkacc = await _userManager.FindByIdAsync(OgAppointment.ProfileId);
                if (checkacc == null)
                {
                    TempData["error"] = "Unable to fine account";
                    return Page();
                }
            }
            else
            {
                var user = new Profile
                {
                    UserName = Profile.Email,
                    Email = Profile.Email,
                    PhoneNumber = Profile.PhoneNumber,
                    FirstName = Profile.FirstName,
                    Title = Profile.Title,
                    SurName = Profile.SurName,
                    LastName = Profile.LastName,
                    Gender = Profile.Gender,
                    MaritalStatus = Profile.MaritalStatus,
                    ReligionStatus = Profile.ReligionStatus,
                    AltPhone = Profile.AltPhone,
                    Address = Profile.Address,
                    Biography = Profile.Biography


                };

               

                user.Id = Guid.NewGuid().ToString();
                var result = await _userManager.CreateAsync(user, "Benue@2023");
                if (result.Succeeded)
                {
                    OgAppointment.ProfileId = user.Id;
                    OgAppointment.OgLevel1Id = RouteId;
                    _context.OgAppointments.Add(OgAppointment);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Details", new { id = RouteId });
                }
                string messages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                TempData["error"] = messages;
                return RedirectToPage("./Details", new { id = RouteId });
            }

            try
            {
                OgAppointment.OgLevel1Id = RouteId;
                _context.OgAppointments.Add(OgAppointment);
                
                await _context.SaveChangesAsync();
                TempData["success"] = "successful";
            }
            catch(Exception c)
            {
                TempData["error"] = c.ToString();
            }
            return RedirectToPage("./Details", new { id = RouteId });
        }
    }
}
