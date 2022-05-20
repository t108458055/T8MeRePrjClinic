using Microsoft.AspNetCore.Mvc;
using RePrjClinicAppoint.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult fill_in_data()  //填入資料
        {
            return View();
        }

        [HttpPost]

        public IActionResult pushUser(NewUserModel NewUser)
        {
            var YA = NewUser;
            Console.WriteLine(YA);
            return Content("OK");
        }
        public class NewUserModel
        {
            public string UserName { get; set; }
            public string UserPassword { get; set; }
            public string UserEmail { get; set; }
        }


    }
}
