using Microsoft.AspNetCore.Mvc;
using UniversityAdmisionApplcation.Models;
using UniversityAdmisionApplcation.Database;

namespace UniversityAdmisionApplcation.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContex _context;
        public AccountController(ApplicationDbContex context)
        {
            _context = context;
        }
        public IActionResult Sign()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sign(Login lg)
        {
          var result= _context.Registrations.Where(r => r.Username == lg.Username && r.Password==lg.Password).ToList();

            if(result.Count > 0)

            {
            

                foreach (var r in result)
                {
                    ViewBag.FirstName = r.FirstName;
                    ViewBag.LastName = r.LastName;
                    if(r.Role=="Student")
                    {
                        ViewBag.Title = "Applicant";
                    }
                    else
                    {
                        ViewBag.Title = r.Role;
                    }
                    

                }


                return RedirectToAction("DashboardPage", "Dashboard");
            }

            TempData["ErrorMessage"] = "error";


            return View();
        }


        public IActionResult Forget()
        {
            return View();
        }
    }
}
