using Microsoft.AspNetCore.Mvc;
using UniversityAdmisionApplcation.Models;

namespace UniversityAdmisionApplcation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Sign()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sign(Login lg)
        {
            return View();
        }


        public IActionResult Forget()
        {
            return View();
        }
    }
}
