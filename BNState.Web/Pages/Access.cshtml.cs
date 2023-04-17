using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BNState.Domain.Models;

namespace BNState.Web.Pages 
{
    [AllowAnonymous]
    public class AccessModel : PageModel
    {
        private readonly UserManager<Profile> _userManager;
        private readonly SignInManager<Profile> _signInManager;
        private readonly ILogger<AccessModel> _logger;

        public AccessModel(SignInManager<Profile> signInManager,
            ILogger<AccessModel> logger,
            UserManager<Profile> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        [BindProperty]
        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl)
        {

            //if (ModelState.IsValid)
            //{
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user != null)
                {

                    var passcheck = await _userManager.CheckPasswordAsync(user, Input.Password);
                    if (passcheck == true && user.LockoutEnabled == true)
                    {

                        _logger.LogWarning("User with ID '{UserId}' account locked out.", user.Id);
                        return RedirectToPage("/Account/Lockout", new { area = "Identity" });

                    }
                    if (passcheck == true && user.TwoFactorEnabled == true)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user.UserName, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                        if (result.Succeeded)
                        {


                             var superrole = await _userManager.IsInRoleAsync(user, "mSuperAdmin");
                            var adminrole = await _userManager.IsInRoleAsync(user, "Dashboard");
                             
                            if (superrole.Equals(true))
                            {
                                ///Categories/Level1
                                return RedirectToPage("/Categories/Level1/Index", new { area = "Secured" });
                            }
                            else if (adminrole.Equals(true))
                            {
                                return RedirectToPage("/Admin/Index", new { area = "Dashboard" });
                            }
                             
                            return LocalRedirect(returnUrl);
                        }
                        if (result.RequiresTwoFactor)
                        {
                            return RedirectToPage("/Account/LoginWith2fa", new { area = "Identity", ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                        }
                        if (result.IsLockedOut)
                        {
                            _logger.LogWarning("User account locked out.");
                            return RedirectToPage("./Lockout");
                        }
                        else
                        {
                            var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                            return Page();
                        }
                    }
                    else if (passcheck == true)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        var superrole = await _userManager.IsInRoleAsync(user, "mSuperAdmin");
                        var adminrole = await _userManager.IsInRoleAsync(user, "Dashboard");

                        if (superrole.Equals(true))
                        {
                            return RedirectToPage("/Main/Index", new { area = "Secured" });
                        }
                        else if (adminrole.Equals(true))
                        {
                            return RedirectToPage("/Admin/Index", new { area = "Dashboard" });
                        }
                        returnUrl = returnUrl ?? Url.Content("~/");


                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return Page();
                    }
                }
                else
                {
                    var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            
            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
