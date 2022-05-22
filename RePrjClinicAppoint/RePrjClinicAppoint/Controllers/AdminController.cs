using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RePrjClinicAppoint.Models;
using RePrjClinicAppoint.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.Controllers
{
    public class AdminController : Controller
    {
        private readonly DentalDbContext _db;  //給目前控制做讀取使用
        private readonly IMapper _mapper;

        //控制器環境設置
        public AdminController(DentalDbContext db,IMapper mapper)
        {//DBcontext 引入至控制器
            _db = db;
            _mapper = mapper;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        //創建帳號至資料庫
        [HttpPost]
        public ActionResult Create([FromForm]RegViewModel model)
        {
            
            if (!ModelState.IsValid)
            {
                //去資料庫比對資料是否存在
                var register = _db.Doctor.Where(c => c.Account == model.Account).DefaultIfEmpty().FirstOrDefault();
                if (register == null)
                {
                    //TODO新增資料
                    _db.Doctor.Add(new Models.Entity.Doctor()
                    {
                        Account = model.Account,
                        Password = model.Password,
                        Name = model.Name,
                        gender = model.Gender,
                        Age = 18,
                        CreateDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

                    });
                    _db.SaveChanges();
                    //return RedirectToAction("Index");
                    return Content("已寫入至資料庫");
                }
                else
                {
                    return Content("此帳號已有人使用");
                }
            }
            return Content("失敗");
        }

        ////TODO從資料庫拿取文件
        //public docshowViewModel Getlist()
        //{
        //    List<docshowViewModel> getuserall = _db.Doctor.Where(x=>x.ToString);

        //    return JsonResult(getuserall);
        //}
    }
}
