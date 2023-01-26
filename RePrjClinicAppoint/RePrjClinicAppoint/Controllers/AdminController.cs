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

        public class myDe
        {
            public string id { get; set; }
            public string Account { get; set; }
            public string name { get; set; }
            public int DoctorId { get; set; }
        }
        //修改
        [HttpGet]
        public ActionResult De(myDe model)
        {
            var sql_D=_db.Doctor.Where(c => c.account== model.Account).FirstOrDefault();
            _db.Doctor.Remove(sql_D);
            sql_D.name = model.name;
            sql_D.account = model.Account;

            sql_D.Id = model.DoctorId;
        /**
            _db.Doctor.Add(new Models.Entity.Doctor()
            {  //將viewmodel所傳進來的參數丟入新建構的物件里
                account = model.Account,
                
                creationDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) //當前所創建日期產生

            });
           */ 
            _db.SaveChanges();
            return Content("修改成功");
        }

        #region Create 創建資料 Method OK
        //創建帳號至資料庫
        [HttpPost]
        public ActionResult Create([FromForm] RegViewModel model)
        {// 使用ViewModel接取前端所傳進來之物件
            if (!ModelState.IsValid)// 判斷與模式是否相似
            {
                //去資料庫比對資料是否存在,並存入至新的物件里
                //var register = _db.Doctor.Where(c => c.Account == model.Account).FirstOrDefault();
                if (!true)  //資料庫里沒此資料
                {
                    //TODO新增資料  與entity 做連接 並新增一要存入資料庫的資料表之物件
                    _db.Doctor.Add(new Models.Entity.Doctor()
                    {  //將viewmodel所傳進來的參數丟入新建構的物件里
                        account = model.Account,
                        password = model.Password,
                        name = model.Name,
                     //   gender = model.Gender,
                        age = 18,
                        creationDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) //當前所創建日期產生

                    });
                    _db.SaveChanges();  //做存入資料庫里
                    return RedirectToAction("Index");
                    return Content("已寫入至資料庫");// 回傳此字串
                }
                else
                {
                    return Content("此帳號已有人使用");// 回傳此字串
                }
            }
            return Content("失敗");// 回傳此字串
        }
        #endregion

        //TODO從資料庫拿取文件
        public List<docshowViewModel> Getlist()
        {  //使用list<>用ViewMoodel做承接所需之資料
            List<docshowViewModel> dicshow = new List<docshowViewModel>();
           // 創建var 的變數去接 資料庫的資料表new一個物件去接資料,並轉呈ToList<>
            var result = _db.Doctor.Select(x => new docshowViewModel
            {
                id = x.Id,
                account = x.account,
                name = x.name

            }).ToList();

            return result;// 回傳此字串
        }

        //TODO 刪除資料庫的資凹
        [Route("[controller]/[action]/{id}")]
        [HttpPost]
        public  IActionResult DeleteDoc([FromRoute] int? id)
        {// 使用Route 方法接取前端所傳進來之編號 int
            //去資料庫比對資料是否存在,並存入至新的物件里
            var result = _db.Doctor.Where(x => x.Id == id).FirstOrDefault();
            //判斷是否空值
            if (result != null)
            {  //做資料表的指定之編號做刪除
                _db.Doctor.Remove(result);
                _db.SaveChanges();
                return Content("刪除成功");// 回傳此字串
            }
            else
            {
                return Content("失敗");// 回傳此字串
            }
        }
    }
}
