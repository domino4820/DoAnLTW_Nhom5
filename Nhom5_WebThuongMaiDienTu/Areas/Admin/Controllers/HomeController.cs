using Microsoft.AspNetCore.Mvc;

namespace Nhom5_WebThuongMaiDienTu.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
