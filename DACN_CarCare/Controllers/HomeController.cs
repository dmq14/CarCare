using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DACN_CarCare.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Baoduong()
        {
            ViewBag.Message = "Bảo dưỡng";

            return View();
        }
        public ActionResult Daunhot()
        {
            ViewBag.Message = "Dầu nhớt";
            return View();
        }
        public ActionResult Sirius()
        {
            ViewBag.Message = "Sirius";

            return View();
        }
        public ActionResult Vario()
        {
            ViewBag.Message = "Vario";

            return View();
        }
        public ActionResult DiaDiem()
        {
            ViewBag.Message = "DiaDiem";

            return View();
        }
        public ActionResult DauPhanh()
        {
            ViewBag.Message = "Dầu phanh";
            return View();
        }
        public ActionResult Bugi()
        {
            ViewBag.Message = "Bugi";
            return View();
        }
        public ActionResult NuocLamMat()
        {
            ViewBag.Message = "Nước Làm Mát";
            return View();
        }
        public ActionResult LocGio()
        {
            ViewBag.Message = "Lọc gió";
            return View();
        }
        public ActionResult DayCuroa()
        {
            ViewBag.Message = "Dây cu - roa";
            return View();
        }
    }
}