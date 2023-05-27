using Microsoft.AspNetCore.Mvc;
using RePrjClinicAppoint.Models;
using RePrjClinicAppoint.Models.Entities;
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

        //從資料庫撈回資料給前端
        public List<QuiryModel> GetData()
        {
            var result = _db.Patient.Select(x => new QuiryModel
            {
                id = x.Id,
                account = x.account,
                name = x.name
            }).ToList();
            return result;
        }

        //
        [HttpPost]
        public string myQ(string myNB)
        {

            var result = _db.Patient.Where(x => x.name.Contains(myNB));
            string show =  "";
            foreach (var x in result)
            {
                show += $"<p>使用者名稱:{x.name}</p>" + "<br/>";

                show += $"使用者密碼:{x.password}<br />";
                show += $"使用者信箱:{x.email}<hr>";

            }

            return show;

        }
 

        [HttpPost]

        public IActionResult pushUser(NewUserModel NewUser)
        {
            var YA = NewUser;
            Console.WriteLine(YA);
            //去跟資料庫比對資料是否存在
            var pushYa = _db.Patient.Where(c => c.email == NewUser.UserEmail).DefaultIfEmpty().FirstOrDefault();
            if (pushYa == null)
            {
           //     ToDO 新增資料

            }


            var user = _db.Patient.Where(x => x.account == NewUser.UserName).FirstOrDefault();
            if (user == null)
            {
                _db.Patient.Add(new Patient()
                {
                    account = NewUser.UserName,
                    password = NewUser.UserPassword,
                    email = NewUser.UserEmail
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

        public class QuiryModel
        {
            public int id { get; set; }
            public string account { get; set; }
            public string name { get; set; }
        }



    }
}
