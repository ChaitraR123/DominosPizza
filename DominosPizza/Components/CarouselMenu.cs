using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DominosPizza.Data;
using DominosPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DominosPizza.Components
{
    public class CarouselMenu : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public CarouselMenu(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pizzas = await _context.Pizzas.Where(x => x.IsPizzaOfTheWeek).ToListAsync();
            return View(pizzas);
        }
    }
}
