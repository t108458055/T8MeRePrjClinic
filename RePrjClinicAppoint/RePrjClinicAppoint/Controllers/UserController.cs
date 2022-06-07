using Microsoft.AspNetCore.Mvc;
using RePrjClinicAppoint.Models;
using RePrjClinicAppoint.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.Controllers
{
    public class UserController : Controller
    {
        private readonly DentalDbContext _db;//給目前控制做讀取使用

        //控制器環境設置
        public UserController(DentalDbContext db)
        {  //引入DbContext 使用
            _db = db;
        }
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
            //var YA = NewUser;
            //Console.WriteLine(YA);
            //去跟資料庫比對資料是否存在
            //var pushYa = _db.Patient.Where(c => c.Email == NewUser.UserEmail).DefaultIfEmpty().FirstOrDefault();
            //if (pushYa==null)
            //{
            //ToDO 新增資料

            //}
            

            var user = _db.Patient.Where(x => x.Account == NewUser.UserName).FirstOrDefault();
            if(user == null)
            {
                _db.Patient.Add(new Patient()
                {
                    Account = NewUser.UserName,
                    Password=NewUser.UserPassword,
                    Email=NewUser.UserEmail
                });
                _db.SaveChanges();
                return Content("OK");
            }
            else
            {
                return Content("fail");
            }


        }
        public class NewUserModel
        {
            public string UserName { get; set; }
            public string UserPassword { get; set; }
            public string UserEmail { get; set; }
        }


    }
}
