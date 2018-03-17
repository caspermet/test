using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ija2.Data;
using Microsoft.EntityFrameworkCore;

namespace ija2.Controllers
{
    public class PhotosController : Controller
    {
        private readonly PhotosContext _context;

        public PhotosController(PhotosContext context)
        {
            _context = context;

        }

        public async Task<IActionResult> Index()
        {

            return View(await _context.Photose.ToListAsync());
        }
    }
}