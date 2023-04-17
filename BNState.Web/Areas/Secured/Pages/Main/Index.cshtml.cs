using BNState.Domain.Dtos;
using BNState.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BNState.Web.Areas.Secured.Pages.Main
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "mSuperAdmin,Admin")]
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


        public async Task<IActionResult> OnPostAsync()
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
                int sn = 0;
                foreach (var item in Dashboard)
                {
                    sn++;
                    if (item.ModelString == "Level1")
                    {
                        var updateitem = await _context.Category1s.FindAsync(item.Id);
                        updateitem.DashboardOrder = sn;
                        _context.Attach(updateitem).State = EntityState.Modified;

                    }
                    if (item.ModelString == "Level2")
                    {
                        var updateitem2 = await _context.Category2s.FindAsync(item.Id);
                        updateitem2.DashboardOrder = sn;
                        _context.Attach(updateitem2).State = EntityState.Modified;

                    }
                    if (item.ModelString == "Level3")
                    {
                        var updateitem3 = await _context.Category3s.FindAsync(item.Id);
                        updateitem3.DashboardOrder = sn;
                        _context.Attach(updateitem3).State = EntityState.Modified;

                    }
                }

                await _context.SaveChangesAsync();
            }
            TempData["success"] = "Successful";
            return RedirectToPage("./Index");



        }
        [BindProperty]
        public long Xid { get; set; }

        [BindProperty]
        public string Xstring { get; set; }

        [BindProperty]
        public int SortId { get; set; }
        public async Task<IActionResult> OnPostUpMove()
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
            var item = await Dashboard.FirstOrDefaultAsync(x => x.DashboardOrder == SortId);
            int xcount = Dashboard.Count();
            if (item.DashboardOrder == 1)
            {
                TempData["success"] = "Successful";
                return RedirectToPage("./Index");
            }
            else
            {
                int top = SortId - 1;
                int newtop = top + 1;
                var topitem = await Dashboard.FirstOrDefaultAsync(x => x.DashboardOrder == top);

                if (topitem.ModelString == "Level1")
                {
                    var updateitem = await _context.Category1s.FindAsync(topitem.Id);
                    updateitem.DashboardOrder = newtop;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                if (topitem.ModelString == "Level2")
                {
                    var updateitem = await _context.Category2s.FindAsync(topitem.Id);
                    updateitem.DashboardOrder = newtop;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                if (topitem.ModelString == "Level3")
                {
                    var updateitem = await _context.Category3s.FindAsync(topitem.Id);
                    updateitem.DashboardOrder = newtop;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }

                ////
                ///
                if (item.ModelString == "Level1")
                {
                    var updateitem = await _context.Category1s.FindAsync(item.Id);
                    updateitem.DashboardOrder = top;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                if (item.ModelString == "Level2")
                {
                    var updateitem = await _context.Category2s.FindAsync(item.Id);
                    updateitem.DashboardOrder = top;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                if (item.ModelString == "Level3")
                {
                    var updateitem = await _context.Category3s.FindAsync(item.Id);
                    updateitem.DashboardOrder = top;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                await _context.SaveChangesAsync();
            }


            
            TempData["success"] = "Successful";
            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostDownMove()
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
            var item = await Dashboard.FirstOrDefaultAsync(x => x.DashboardOrder == SortId);
            int xcount = Dashboard.Count();
            if (item.DashboardOrder == xcount)
            {
                TempData["success"] = "Successful";
                return RedirectToPage("./Index");
            }
            else
            {
                int top = SortId + 1;
                int newtop = top - 1;
                var topitem = await Dashboard.FirstOrDefaultAsync(x => x.DashboardOrder == top);

                if (topitem.ModelString == "Level1")
                {
                    var updateitem = await _context.Category1s.FindAsync(topitem.Id);
                    updateitem.DashboardOrder = newtop;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                if (topitem.ModelString == "Level2")
                {
                    var updateitem = await _context.Category2s.FindAsync(topitem.Id);
                    updateitem.DashboardOrder = newtop;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                if (topitem.ModelString == "Level3")
                {
                    var updateitem = await _context.Category3s.FindAsync(topitem.Id);
                    updateitem.DashboardOrder = newtop;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }

                ////
                ///
                if (item.ModelString == "Level1")
                {
                    var updateitem = await _context.Category1s.FindAsync(item.Id);
                    updateitem.DashboardOrder = top;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                if (item.ModelString == "Level2")
                {
                    var updateitem = await _context.Category2s.FindAsync(item.Id);
                    updateitem.DashboardOrder = top;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                if (item.ModelString == "Level3")
                {
                    var updateitem = await _context.Category3s.FindAsync(item.Id);
                    updateitem.DashboardOrder = top;
                    _context.Attach(updateitem).State = EntityState.Modified;

                }
                await _context.SaveChangesAsync();
            }



            TempData["success"] = "Successful";
            return RedirectToPage("./Index");
        }

    }

}
