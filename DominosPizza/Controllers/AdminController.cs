using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DominosPizza.Repositories;
using DominosPizza.Models;
using DominosPizza.Data;

namespace DominosPizza.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
       

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
            
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}