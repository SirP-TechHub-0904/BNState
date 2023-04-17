using Amazon.S3;
using BNState.Domain.Data;
using BNState.Domain.Dtos.AwsDtos;
using BNState.Domain.Services.AWS;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BNState.Pages.Shared.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
         
        public CategoryMenuViewComponent(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public string UserInfo { get; set; }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var slider = await _context.Category1s.OrderBy(x=>x.Order).ToListAsync();
            return View(slider);
        }
    }
}
