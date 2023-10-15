using CarRentalWebService.Services;
using Microsoft.AspNetCore.Mvc;



namespace CarRentalWebService.Controllers
{
    public class AdminsController : Controller
    {
        private readonly AdminService _adminService;

        public AdminsController(AdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var list = _adminService.FindAllAdmins();

            return View(list);
        }
    }
}
