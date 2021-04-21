using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MDS_Web.DAO;
using MDS_Web.EF;

namespace MDS_Web.Controllers
{
    public class HomeController : Controller
    {
        Dbcontext db = new Dbcontext();
        public ActionResult Index()
        {
            var dao1 = new Dao();            
            ViewBag.MaHangSX = dao1.ListAllHang();
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

        public JsonResult GetStateList(int MaHangSX)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<LOAIXE> LoaiXeList = db.LOAIXE.Where(x => x.MaHangSX == MaHangSX).ToList();
            return Json(LoaiXeList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetStateList2(int MaLoaiXe)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<CAUHOI> LoaiXeList = db.CAUHOI.Where(x => x.MaLoaiXe == MaLoaiXe).ToList();
            return Json(LoaiXeList, JsonRequestBehavior.AllowGet);
        }
    }
}