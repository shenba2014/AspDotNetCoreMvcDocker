using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspDotNetCoreMvcDocker.Models;
using Microsoft.Extensions.Configuration;

namespace AspDotNetCoreMvcDocker.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;
        private string message;

        public HomeController(IRepository repository, IConfiguration config)
        {
            _repository = repository;
            message = config["MESSAGE"] ?? "Essential Docker";
        }

        public IActionResult Index()
        {
            ViewBag.Message = message;
            return View(_repository.Books);
        }
    }
}
