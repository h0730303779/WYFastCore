using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WYCore.Web.Areas.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 初始页面
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return Redirect("/Admin/Login/Index");
        }
    }
}