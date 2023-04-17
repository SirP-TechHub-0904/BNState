using BNState.Domain.Dtos.AwsDtos;
using BNState.Domain.Models;
using BNState.Domain.Services.AWS;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.ProfilePage
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]

    public class ProfileUpdateModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;
        private readonly IConfiguration _config;
        private readonly IStorageService _storageService;

        public ProfileUpdateModel(BNState.Domain.Data.ApplicationDbContext context, UserManager<Profile> userManager, IConfiguration config, IStorageService storageService)
        {
            _context = context;
            _userManager = userManager;
            _config = config;
            _storageService = storageService;
        }

        [BindProperty]
        public Profile Profile { get; set; }

        [BindProperty]
        public long LevelId { get; set; }
        [BindProperty]
        public IFormFile? file { get; set; }

        [BindProperty]
        public string P1 { get; set; }
        [BindProperty]
        public string P2 { get; set; }
        [BindProperty]
        public long? Lid { get; set; }

        public async Task<IActionResult> OnGetAsync(string id, string p1, string p2, long? lid)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _userManager.FindByIdAsync(id);
            if (profile == null)
            {
                return NotFound();
            }

            if (lid == null)
            {
                return NotFound();
            }

            if (p2.ToUpper() == "LEVEL2")
            {
                var levels = await _context.Category2s.FindAsync(lid);
                if (levels == null)
                {
                    return NotFound();
                }
                Lid = levels.Id; LevelId = levels.Id;
            }
            else if (p2.ToUpper() == "LEVEL1")
            {
                var levels = await _context.Category1s.FindAsync(lid);
                if (levels == null)
                {
                    return NotFound();
                }
                Lid = levels.Id; LevelId = levels.Id;
            }
            else if (p2.ToUpper() == "LEVEL3")
            {
                var levels = await _context.Category3s.FindAsync(lid);
                if (levels == null)
                {
                    return NotFound();
                }
                Lid = levels.Id; LevelId = levels.Id;
            }
            else if (p2.ToUpper() == "LEVEL4")
            {
                var levels = await _context.Category4s.FindAsync(lid);
                if (levels == null)
                {
                    return NotFound();
                }
                Lid = levels.Id; LevelId = levels.Id;
            }

            Profile = profile;
            P1 = p1;
            P2 = p2;

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            var updateprofile = await _userManager.FindByIdAsync(Profile.Id);
            if (updateprofile != null)
            {

                if (file != null)
                {
                    try
                    {
                        // Process file
                        await using var memoryStream = new MemoryStream();
                        await file.CopyToAsync(memoryStream);

                        var fileExt = Path.GetExtension(file.FileName);
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

                        var xresult = await _storageService.UploadFileReturnUrlAsync(s3Obj, cred, updateprofile.Key);
                        // 
                        if (xresult.Message.Contains("200"))
                        {
                            updateprofile.PhotoUrl = xresult.Url;
                            updateprofile.Key = xresult.Key;
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

                updateprofile.Title = Profile.Title;
                updateprofile.SurName = Profile.SurName;
                updateprofile.FirstName = Profile.FirstName;
                updateprofile.LastName = Profile.LastName;
                updateprofile.Email = Profile.Email;
                updateprofile.PhoneNumber = Profile.PhoneNumber;
                updateprofile.AltPhone = Profile.AltPhone;
                updateprofile.Address = Profile.Address;
                updateprofile.Gender = Profile.Gender;
                updateprofile.MaritalStatus = Profile.MaritalStatus;
                updateprofile.ReligionStatus = Profile.ReligionStatus;
                updateprofile.Biography = Profile.Biography;
            }



            try
            {
                await _userManager.UpdateAsync(updateprofile);

            }
            catch (DbUpdateConcurrencyException)
            {

                throw;

            }
            string dataroute = "/" + P1 + "/" + P2 + "/Details";

            return RedirectToPage(dataroute, new { id = Lid });
        }

    }
}