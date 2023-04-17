using BNState.Domain.Dtos.AwsDtos;
using BNState.Domain.Models;
using BNState.Domain.Services.AWS;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Categories.Level2
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
    public class UpdateModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;
        private readonly UserManager<Profile> _userManager;
        private readonly IConfiguration _config;
        private readonly IStorageService _storageService;

        public UpdateModel(BNState.Domain.Data.ApplicationDbContext context, UserManager<Profile> userManager, IConfiguration config, IStorageService storageService)
        {
            _context = context;
            _userManager = userManager;
            _config = config;
            _storageService = storageService;
        }

        public async Task<IActionResult> OnGetAsync(long? id, long? mid)
        {
            if (mid == null)
            {
                return RedirectToPage("/Result", new { error = "Invalid Data" });
            }

            CategoryAppointment = await _context.CategoryAppointments.Include(x=>x.Profile).FirstOrDefaultAsync(m => m.Id == id);
            if (CategoryAppointment == null)
            {
                return RedirectToPage("/Result", new { error = "Invalid Level" });
            }

            if (id == null)
            {
                return RedirectToPage("/Result", new { error = "Invalid Data" });
            }

            Category2 = await _context.Category2s.FirstOrDefaultAsync(m => m.Id == mid);
            if (Category2 == null)
            {
                return RedirectToPage("/Result", new { error = "Invalid Level" });
            }

            var list = _context.Users.Where(x => x.Email != "admin@abia.com").OrderBy(x => x.Title).AsQueryable();
            ViewData["ProfileId"] = new SelectList(list, "Id", "Fullname");

            RouteId = id;
            return Page();
        }

        [BindProperty]
        public CategoryAppointment CategoryAppointment { get; set; } = default!;
        public Category2 Category2 { get; set; } = default!;

        [BindProperty]
        public long? RouteId { get; set; }
        [BindProperty]
        public string? OldKey { get; set; }
        [BindProperty]
        public bool NewAccount { get; set; }

        [BindProperty]
        public Profile Profile { get; set; } = default!;
        [BindProperty]
        public IFormFile? file { get; set; }
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (String.IsNullOrEmpty(Profile.SurName))
            {
                var checkacc = await _userManager.FindByIdAsync(CategoryAppointment.ProfileId);
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

                            var xresult = await _storageService.UploadFileReturnUrlAsync(s3Obj, cred, OldKey);
                            // 
                            var updateuser = await _userManager.FindByIdAsync(user.Id);
                            if (xresult.Message.Contains("200"))
                            {
                                updateuser.PhotoUrl = xresult.Url;
                                updateuser.Key = xresult.Key;
                                await _userManager.UpdateAsync(updateuser);
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
                    CategoryAppointment.ProfileId = user.Id;
                    _context.CategoryAppointments.Add(CategoryAppointment);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Details", new { id = RouteId });
                }
                string messages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                TempData["error"] = messages;
                return RedirectToPage("./Details", new { id = CategoryAppointment.Category2Id });
            }

            try
            {
                
                 _context.Attach(CategoryAppointment).State = EntityState.Modified;
                await _context.SaveChangesAsync();

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

                        var xresult = await _storageService.UploadFileReturnUrlAsync(s3Obj, cred, OldKey);
                        // 
                        var updateuser = await _userManager.FindByIdAsync(CategoryAppointment.ProfileId);
                        if (xresult.Message.Contains("200"))
                        {
                            updateuser.PhotoUrl = xresult.Url;
                            updateuser.Key = xresult.Key;
                            await _userManager.UpdateAsync(updateuser);
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
                TempData["success"] = "successful";
                return RedirectToPage("./Details", new { id = CategoryAppointment.Category2Id });

            }
            catch (Exception c)
            {
                TempData["error"] = c.ToString();
            }
            return RedirectToPage("./Details", new { id = CategoryAppointment.Category2Id });
        }
    }
}
