using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPIRestAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class StudentPortalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
