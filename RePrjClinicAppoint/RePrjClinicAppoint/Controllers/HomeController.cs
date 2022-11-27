using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RePrjClinicAppoint.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; //給目前控制做讀取使用

        //控制器環境設置
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
        public int[] AAA([FromBody] numsA b)
        {
            //var a = new numsA();
            var AAA = new int[] { };
            AAA = twoSum(b.nums, b.target);
            return AAA;
        }
        public int[] twoSum(int[] nums, int target)
        {
            int[] a = new int[2];
            Dictionary<int, int> myDiction = new Dictionary<int, int>();
            for (int c = 0; c < nums.Length; c++)
            {
                if (myDiction.ContainsKey(target - nums[c]))
                {
                    a[1] = c;
                    a[0] = myDiction[target - nums[c]];
                    return a;
                }
                if (!myDiction.ContainsKey(nums[c]))
                    myDiction.Add(nums[c], c);
            }
            return null;
        }
        public class numsA
        {
            public int[] nums { get; set; }
            public int target { get; set; }
        }

    }
}
