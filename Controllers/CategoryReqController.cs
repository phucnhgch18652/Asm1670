using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheNew1.Models;
using TheNew1.Data;

namespace TheNew1.Controllers
{
    public class CategoryReqController : Controller
    {
        private readonly FPTBookDbContext _context;
        public CategoryReqController(FPTBookDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.CategoryReqs.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Req")] CategoryReq categoryreq)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryreq);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoryreq);
        }
    }
}
