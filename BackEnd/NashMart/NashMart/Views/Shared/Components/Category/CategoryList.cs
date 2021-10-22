using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NashMart.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NashMart.Views.Shared.Components.Category
{
    public class CategoryList : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public CategoryList(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);

        }

     
    }
}
