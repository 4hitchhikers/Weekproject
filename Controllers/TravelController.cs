using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeekProject.Models;

namespace WeekProject.Controllers
{
    public class TravelController : Controller
    {
        [HttpGet]
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            ViewBag.Email = HttpContext.Session.GetString("email");
            return View();
        }
    }
}
