using Day1ITIASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1ITIASP.Controllers
{
    public class StudentController : Controller
    {
        AppDBcontext DB = new AppDBcontext();
        public ViewResult GetAll()
        {
            var students = DB.Students.ToList();
            return View("Index",students);

        }
        public ViewResult GetStudentBySSN(int ssn)
        {
            var student = DB.Students.Find(ssn);

            if (student == null)
            {
               
                ViewBag.Message = "Student not found!";
                return View("NotFound");
            }

            
            return View("Index1", student);
            

        }
    }
}
