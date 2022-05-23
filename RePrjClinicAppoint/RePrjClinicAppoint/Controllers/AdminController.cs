﻿using AutoMapper;
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
                var register = _db.Doctor.Where(c => c.Account == model.Account).FirstOrDefault();
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

        //TODO從資料庫拿取文件
        public List <docshowViewModel> Getlist()
        {  //使用list<>用ViewMoodel做承接所需之資料
            // List<docshowViewModel> dicshow = new List<docshowViewModel>();
            //創建var 的變數去接 資料庫的資料表new一個物件去接資料,並轉呈ToList<>
            var result = _db.Doctor.Select(x=> new docshowViewModel 
            {
                id=x.DoctorId,
                account=x.Account,
                name=x.Name
            
            }).ToList();

            return result;
        }


        //TODO 刪除資料庫的資凹
        [Route("[controller]/[action]/{id}")]
        [HttpPost]
        public  IActionResult DeleteDoc([FromRoute] int? id)
        {
            var result = _db.Doctor.Where(x => x.DoctorId == id).FirstOrDefault();

            if (result != null)
            {
                _db.Doctor.Remove(result);
                _db.SaveChanges();
                return Content("刪除成功");
            }
            else
            {
                return Content("失敗");
            }
        }
    }
}
