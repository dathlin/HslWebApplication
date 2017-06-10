using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HslWebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        /***************************************************************************************
         * 
         *    用来生成一些基础数据的控制器
         * 
         ***************************************************************************************/
        [HttpPost]
        public ActionResult GetSexCombobox()
        {
            string[] data = new string[] { "男", "女" };
            return Json(data);
        }

    }
}