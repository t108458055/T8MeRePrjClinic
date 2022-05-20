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

        public AdminController(DentalDbContext db)
        {//DBcontext 引入至控制器
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(RegViewModel model)
        {
            return View();

        }
    }
}
