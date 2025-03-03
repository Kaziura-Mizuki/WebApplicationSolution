using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
using WebApplication2.Models;
using Microsoft.Extensions.Logging;
using static WebApplication2.Models.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication2.Service;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        CommonService commonService = new CommonService();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        

        public IActionResult Home()
        {
            return View();
        }

        public ActionResult GetMessages()
        {
            return Json(new { message = "Greetings from server!" });
        }


    }
}
