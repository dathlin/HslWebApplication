using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HslWebApplication2.Controllers
{
    public class MenuController : Controller
    {

        /***************************************************************************************
         * 
         *    日期：     2017年6月5日 14:02:13
         *    创建人：   Richard.Hu
         *    说明：     该控制器为菜单控制器，用来实现对所访问的菜单进行响应请求
         * 
         ***************************************************************************************/

        #region 账户相关

        [HttpPost]
        public ActionResult GetContacts()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetContactsData()
        {
            return Json(Database.SoftAccount.GetAllList());
        }

        [HttpPost]
        public ActionResult GetContactsTwo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult save_user()
        {
            return View();
        }
        [HttpPost]
        public ActionResult update_user()
        {
            return View();
        }
        [HttpPost]
        public ActionResult destroy_user()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetContactsThree()
        {
            return View();
        }

        #endregion




        #region 工作汇报相关界面


        //POST

        [HttpPost]
        public ActionResult WorkWeek()
        {
            System.Threading.Thread.Sleep(1000);
            return View();
        }



        #endregion



    }
}