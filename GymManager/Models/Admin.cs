using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymManagementWebsite.Controllers
{
    [Authorize(Roles = "Admin")]  // sadece admin giriþ yapabilir
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Antrenör Yönetimi
        public IActionResult Trainers()
        {
            return RedirectToAction("Index", "Trainer");
        }

        // Hizmet Yönetimi
        public IActionResult Services()
        {
            return RedirectToAction("Index", "Service");
        }

        // Spor Salonu Yönetimi
        public IActionResult Gyms()
        {
            return RedirectToAction("Index", "Gym");
        }

        // Raporlama
        public IActionResult Reports()
        {
            return RedirectToAction("Index", "Report");
        }
    }
}
