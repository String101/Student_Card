using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Card.Interface;
using Student_Card.Models;
using Student_Card.ViewModel;

namespace Student_Card.Controllers
{
    [Authorize(Roles = SD.Role_Admin)]
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var student = _unitOfWork.Student.GetAll(includeProperties: "Course");
            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
              StudentVM studentVM = new StudentVM()
              {
                  CourseList=_unitOfWork.Course.GetAll().Select(u=> new SelectListItem
                  {
                      Text = u.CourseName,
                      Value = u.ID.ToString(),
                  })
              };
            return View(studentVM);
        }
        [HttpPost]
        public IActionResult Create(StudentVM obj)
        {
            bool StudentExists = _unitOfWork.Student.Any(u => u.Student_Number == obj.Student.Student_Number);

            if (ModelState.IsValid && !StudentExists && obj.Student.Student_Number.Length == 9)
            {
                _unitOfWork.Student.Add(obj.Student);
                _unitOfWork.Save();
                TempData["success"] = "The Student has been created successfully.";
                return RedirectToAction(nameof(Index));
            }
            if (obj.Student.Student_Number.Length < 9)
            {
                TempData["error"] = "The Invalid Student Number ";
                return View(obj);
            }
            obj.CourseList = _unitOfWork.Student.GetAll().Select(u => new SelectListItem
            {
                Text = u.Course.CourseName,
                Value = u.CourseId.ToString(),
            });
            return View(obj);

        }
        [HttpGet]
        public IActionResult Update(string studentNumber)
        {
            StudentVM studentVM = new()
            {
                CourseList = _unitOfWork.Course.GetAll().Select(u => new SelectListItem
                {
                    Text = u.CourseName,
                    Value = u.ID.ToString(),
                }),
                Student = _unitOfWork.Student.Get(u => u.Student_Number == studentNumber)
            };

            if (studentVM.Student == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(studentVM);
        }
        [HttpPost]
        public IActionResult Update(StudentVM studentVM)
        {



            if (ModelState.IsValid)
            {
                _unitOfWork.Student.Update(studentVM.Student);
                _unitOfWork.Save();
                TempData["success"] = "The Student has been updated successfully.";
                return RedirectToAction(nameof(Index));
            }



            studentVM.CourseList = _unitOfWork.Course.GetAll().Select(u => new SelectListItem
            {
                Text = u.CourseName,
                Value = u.ID.ToString(),
            }
            );
            return View(studentVM);

        }
        public IActionResult Delete(string studentNumber)
        {
            var student = _unitOfWork.Student.Get(u => u.Student_Number == studentNumber, includeProperties: "Course");
            return View(student);
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            Student objfromDb = _unitOfWork.Student.Get(x => x.Student_Number == student.Student_Number);


            if (objfromDb is not null)
            {
                _unitOfWork.Student.Remove(objfromDb);
                _unitOfWork.Save();
                TempData["success"] = "The Student has been deleted successfully.";
                return RedirectToAction(nameof(Index));

            }
            TempData["error"] = "The Student can not be deleted.";

            return View(student);

        }
    }
}
