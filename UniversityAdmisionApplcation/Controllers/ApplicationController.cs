using Microsoft.AspNetCore.Mvc;
using UniversityAdmisionApplcation.Database;
using UniversityAdmisionApplcation.Models;

namespace UniversityAdmisionApplcation.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly ApplicationDbContex _context;
        public ApplicationController (ApplicationDbContex context)
        {
            _context = context;
        }

        public IActionResult Applications()
        {
           // List<Registration> reg = new List<Registration>();

          //var result= _context.Registrations.ToList();



            return View();
        }

        public IActionResult Process()
        {
            return View();
        }
    }
}
