using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheNew1.Models;
using TheNew1.Data;
using System.Security.Cryptography;
using System.Text;

namespace Asm.Controllers
{
    public class HomeController : Controller
    {
        private readonly FPTBookDbContext _context;
        public HomeController(FPTBookDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>Index(String searchString)
        {
            var books = from a in _context.Books select a;
            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(y => y.Name.Contains(searchString));
            }
            return View(await books.ToListAsync());
        }
    }
}