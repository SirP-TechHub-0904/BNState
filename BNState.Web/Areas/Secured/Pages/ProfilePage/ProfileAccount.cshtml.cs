using BNState.Domain.Data.Migrations;
using BNState.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.ProfilePage
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]

    public class ProfileAccountModel : PageModel
    {
        private readonly UserManager<Profile> _userManager;
         private readonly ILogger<ProfileAccountModel> _logger;
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public ProfileAccountModel(
            ILogger<ProfileAccountModel> logger,
            UserManager<Profile> userManager,
            Domain.Data.ApplicationDbContext context)
        {
            _userManager = userManager;
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public Profile Profile { get; set; }
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
                Lid = levels.Id;
            }
            else if (p2.ToUpper() == "LEVEL1")
            {
                var levels = await _context.Category1s.FindAsync(lid);
                if (levels == null)
                {
                    return NotFound();
                }
                Lid = levels.Id;
            }
            else if (p2.ToUpper() == "LEVEL3")
            {
                var levels = await _context.Category3s.FindAsync(lid);
                if (levels == null)
                {
                    return NotFound();
                }
                Lid = levels.Id;
            }
            else if (p2.ToUpper() == "LEVEL4")
            {
                var levels = await _context.Category4s.FindAsync(lid);
                if (levels == null)
                {
                    return NotFound();
                }
                Lid = levels.Id;
            }
            Profile = profile;
            P1 = p1;
            P2 = p2;
            
            return Page();
        }

     }
}
