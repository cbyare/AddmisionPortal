using Microsoft.AspNetCore.Mvc;
using UniversityAdmisionApplcation.Database;
using UniversityAdmisionApplcation.Models;

namespace UniversityAdmisionApplcation.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContex _context;

        public RegistrationController (ApplicationDbContex contex)
        {
            _context = contex;
        }
        public IActionResult Register()
        {
           
            
          ViewBag.Faculties =  _context.Faculties.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Register( Registration obj , IFormFile File)
        {

            if(obj.EducationLevel =="2")
            {
                obj.EducationLevel = "Master Degree";
            }
            else if (obj.EducationLevel == "1")
            {
                obj.EducationLevel = "Bachelor Degree";
            }
            else if (obj.EducationLevel == "3")
            {
                obj.EducationLevel = "PHD";
            }

            obj.Role = "Student";
            obj.File = File.FileName;
            _context.Registrations.Add(obj);
           var result = _context.SaveChanges();
            if(result > 0)
            {
                TempData["ErrorMessage"] = "Success";
            }

            else
            {
                 
                TempData["ErrorMessage"] = "error";
            }

            ViewBag.Faculties = _context.Faculties.ToList();


            return View();
        }
    }
}
