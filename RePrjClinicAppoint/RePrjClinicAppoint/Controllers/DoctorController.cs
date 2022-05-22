using Microsoft.AspNetCore.Mvc;
using RePrjClinicAppoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.Controllers
{
    public class DoctorController : Controller
    {
        private readonly DentalDbContext _db;  //給目前控制做讀取使用

        //控制器環境設置
        public DoctorController(DentalDbContext db)
        {//DBcontext 引入至控制器
            _db = db;
        }
        //掩飾
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
