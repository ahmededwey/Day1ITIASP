using Day1ITIASP.Models;
using Microsoft.AspNetCore.Mvc;


namespace Day1ITIASP.Controllers
{
    public class InstructorController : Controller
    {

        private readonly IInstructorRepository _repo;
        public InstructorController(IInstructorRepository repo) { _repo = repo; }

        public IActionResult Index()
        {
            var instructors = _repo.GetAll();
            return View(instructors);
        }

        public IActionResult Details(int id)
        {
            var instructor = _repo.GetById(id);
            if (instructor == null)
            {
                return NotFound();
            }
            return View(instructor);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Instructor model)
        {
            if (!ModelState.IsValid) return View(model);

            _repo.Add(model);
            _repo.Save();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var instructor = _repo.GetById(id);
            if (instructor == null) return NotFound();
            ViewBag.Depts = _repo.GetAll();
            return View(instructor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Instructor model)
        {
            if (!ModelState.IsValid) return View(model);

            _repo.Update(model);
            _repo.Save();
            return RedirectToAction(nameof(Index));
        }



    }
}
