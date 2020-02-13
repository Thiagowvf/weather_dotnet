using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace weather_dotnet.Controllers
{
    public class weatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}