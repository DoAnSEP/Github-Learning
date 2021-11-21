using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Train.Controllers
{
    public class TrainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
