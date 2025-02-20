using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
using WebApplication2.Models;
using static WebApplication2.Models.ResultViewModel;
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
        /*
        public HomeController(AppDbContext context)
        {
            _context = context;
        }*/

        CommonService commonService = new CommonService();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult GetMessages()
        {
            return Json(new { message = "Greetings from server!" });
        }

        public ActionResult GetData(int id)
        {
            var resultlist = new List<Result>();
            var result = new Result();
            var model = new ResultViewModel();
            result.FirstName = "";
            result.FamilyName = "";
            if(id > 0 || id <= model.familyNameList.Length)
            {
                result.FamilyName = model.familyNameList[id];
                result.FirstName = model.firstNameList[id];
            }
            resultlist.Add(result);
            return Json(new { data = resultlist });
        }

        public ActionResult GetTodo()
        {
            var resultlist = new List<TodoViewModel>();
            var result = new TodoViewModel();
            var data = _context.Todo.ToList();
            if (data.Count == 0)
            {
                result.user_id = 0;
                result.username = "No data found";
                result.password = "No data found";
                resultlist.Add(result);
            }
            else
            {
                for (int i = 0; i < data.Count; i++)
                {
                    result.user_id = data[i].user_id;
                    result.username = data[i].username;
                    result.password = data[i].password;
                    resultlist.Add(result);
                }
            }
            return Json(new { data = resultlist });
        }

        public ActionResult CreateUser(TodoViewModel model)
        {
            if (model == null)
            {
                return Json(new { status = false });
            }
            else
            {
                Todo todo = new Todo();
                var newId = commonService.GetNextSequenceValue("Users_seq");
                todo.user_id = newId;
                todo.username = model.username;
                todo.password = model.password;
                _context.Todo.Add(todo);
                return Json(new { status = true });
            }
        }
    }
}
