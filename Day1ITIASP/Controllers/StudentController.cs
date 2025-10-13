using Day1ITIASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1ITIASP.Controllers
{
    public class StudentController : Controller
    {
        AppDBcontext DB = new AppDBcontext();
        public IActionResult GetAll()
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








        public IActionResult AddNewStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                DB.Students.Add(student);
                DB.SaveChanges();
                return RedirectToAction("GetAll");
            }

            return View("Index2", student);
        }
    }
}
