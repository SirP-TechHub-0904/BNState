using BNState.Domain.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Pages
{
    [Microsoft.AspNetCore.Authorization.Authorize]

    public class ComingSoonModel : PageModel
    {
        private readonly BNState.Domain.Data.ApplicationDbContext _context;

        public ComingSoonModel(BNState.Domain.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CategoryDto> Category { get; set; } = default!;
        public CategoryDto Category2 { get; set; } = default!;


        public async Task<IActionResult> OnGetAsync(long id, string p1, string p2)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (p1 == "Category2")
            {
                var category2 = await _context.Category2s.Include(x => x.Appointments).ThenInclude(x => x.Profile).FirstOrDefaultAsync(m => m.Id == id);
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

                    }; Category2 = mainoutput;
                }
                else
                {

                    var mainoutput = new CategoryDto
                    {
                        Id = category2.Id,
                        Title = category2.Title,

                        Color = category2.Color,

                    }; Category2 = mainoutput;
                }


                if (Category2 == null)
                {
                    return RedirectToPage("/Index");
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
            }
            return Page();
        }
    }
}
