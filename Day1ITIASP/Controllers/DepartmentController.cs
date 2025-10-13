using Day1ITIASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1ITIASP.Controllers
{
    public class DepartmentController : Controller
    {
        AppDBcontext DB = new AppDBcontext();
        public IActionResult GetAll()
        {
            var departments = DB.Departments.ToList();
            return View("Index",departments);

        }
        
        public IActionResult Details(int id)
        {
            var department = DB.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            return View("Details",department);
        }

        public IActionResult GetByName(string name)
        {
            var department = DB.Departments.FirstOrDefault(d => d.Name == name);
            if (department == null)
            {
                return NotFound();
            }
            return View("Index", department);
        }

        public IActionResult AddNewDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                DB.Departments.Add(department);
                DB.SaveChanges();
                return RedirectToAction("GetAll");
            }

            return View("Add", department);
        }
    }
}
