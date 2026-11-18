using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VuongTrungHieu_241230729.Models;

namespace VuongTrungHieu_241230729.Controllers
{
    public class HomeController : Controller
    {
       private readonly QLNhaSachContext _db;
       public HomeController(QLNhaSachContext db)
        {
            _db = db;
        }
       public IActionResult Index()
        {
            var ds=_db.Saches.Where(s=>s.Gia!=null&&s.Gia>=100).ToList();
            ViewBag.TieuDe = "Vương Trung Hiếu";
            return View(ds);
        }
       public IActionResult SachTheoLoai(int id)
        {
            var ds=_db.Saches.Where(s=>s.MaTl==id).ToList();
            ViewBag.TieuDe = _db.TheLoais.Find(id)?.TenTl;
            return PartialView("_DanhSach", ds);
        }
    }
}
