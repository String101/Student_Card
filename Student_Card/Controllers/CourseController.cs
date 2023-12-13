using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Student_Card.Interface;
using Student_Card.Models;

namespace Student_Card.Controllers
{
    [Authorize(Roles =SD.Role_Admin)]
    public class CourseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var course=_unitOfWork.Course.GetAll();
            return View(course);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Course.Add(course);
                _unitOfWork.Save();
                TempData["success"] = "The Course has been created successfully.";
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "The Course can not be created.";
            return View();
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            Course obj = _unitOfWork.Course.Get(x => x.ID == Id);
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Update(Course course)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Course.Update(course);
                _unitOfWork.Save();
                TempData["success"] = "The Course has been updated successfully.";
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "The Course can not be updated.";
            return View();
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            Course obj = _unitOfWork.Course.Get(x => x.ID == Id);
            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Course obj = _unitOfWork.Course.Get(x => x.ID == Id);
            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Delete(Course course)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Course.Remove(course);
                _unitOfWork.Save();
                TempData["success"] = "The Course has been deleted successfully.";
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "The Course can not be deleted.";

            return View();
        }
    }
}
