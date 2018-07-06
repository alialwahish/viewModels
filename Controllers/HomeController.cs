using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModel.Models;

namespace viewModel.Controllers
{
    public class HomeController : Controller
    {

           User user = new User(){
                First_Name="Ali",
                Last_Name="Bayati",
                Numbers=new int[]{1,2,5,77},
                Users= new List<string>{"Rose","Zach"},
                Message="message message messagemessage messagemessagemessagemessage"

            };
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {

            return View(user);
        }

         [HttpGet]
        [Route("numbers")]
        public IActionResult Numbers()
        {

            return View(user);
        }

         [HttpGet]
        [Route("users")]
        public IActionResult Users()
        {

            return View(user);
        }

         [HttpGet]
        [Route("user")]
        public IActionResult User()
        {

            return View(user);
        }

      
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
