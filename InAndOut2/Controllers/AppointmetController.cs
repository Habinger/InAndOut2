using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOut2.Controllers
{
    public class AppointmetController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
    }
}
