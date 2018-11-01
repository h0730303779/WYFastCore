using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WYCore.Web.Areas.Admin.Data;

namespace WYCore.Web.Areas.Admin.Controllers
{
    public class MainController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }



        /// <summary>
        /// 经典版
        /// </summary>
        /// <returns></returns>
        public IActionResult AdminDefault()
        {
            return View();
        }

        /// <summary>
        /// 风尚版
        /// </summary>
        /// <returns></returns>
        public IActionResult AdminLTE()
        {
            return View();
        }


        /// <summary>
        /// 炫动版
        /// </summary>
        /// <returns></returns>
        public IActionResult AdminWindos()
        {
            return View();
        }

        /// <summary>
        /// 飞扬版
        /// </summary>
        /// <returns></returns>
        public IActionResult AdminPretty()
        {
            return View();
        }
    }
}