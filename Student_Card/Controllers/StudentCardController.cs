using Microsoft.AspNetCore.Mvc;
using Student_Card.Interface;
using Student_Card.Models;
using Student_Card.ViewModel;

namespace Student_Card.Controllers
{
    public class StudentCardController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _unitOfWork;

        public StudentCardController(IWebHostEnvironment webHostEnvironment, IUnitOfWork unitOfWork)
        {
            _webHostEnvironment = webHostEnvironment;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(string user)
        {
            ApplicationUser objUser=_unitOfWork.User.Get(x=> x.UserName==user);

            if (objUser!=null)
            {
                StudentCardVM studentCardVM = new StudentCardVM()
                {
                    StudentCard=_unitOfWork.StudentCard.GetAll(includeProperties: "Student"),
                    CourseList=_unitOfWork.Course.GetAll(),
                    Role=objUser.Role,
                };
                if (studentCardVM.Role == SD.Role_Admin)
                {
                    return View(studentCardVM);
                }
                else
                {
                    var student = _unitOfWork.StudentCard.Get(u => u.StudentID == objUser.StudentNumber, includeProperties: "Student");
                    return View("Index2",student);
                }
            }
            return View();
        }

        public IActionResult Create(string user)
        {

            ApplicationUser obj = _unitOfWork.User.Get(x => x.UserName == user);
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentStudentCardVM studentViewModel, string user)
        {
            ApplicationUser obj = _unitOfWork.User.Get(x => x.UserName == user);
            studentViewModel.StudentCard.StudentID = obj.StudentNumber;
            var student = _unitOfWork.Student.Get(u => u.Student_Number == obj.StudentNumber, includeProperties: "Course");
            
            bool StudentExists = _unitOfWork.StudentCard.Any(u => u.StudentID == studentViewModel.StudentCard.StudentID);
            if (StudentExists)
            {
                TempData["error"] = "Student Already exist";
                return View();
            }
            else
            {
                bool StudentExist = _unitOfWork.Student.Any(u => u.Student_Number == studentViewModel.StudentCard.StudentID);
                if (StudentExist)
                {
                    ModelState.Remove("StudentCard.Year");
                    if (ModelState.IsValid && studentViewModel.StudentCard.Year == DateTime.Now.Year)
                    {
                        if (studentViewModel.StudentCard.Image != null)
                        {
                            string filename = Guid.NewGuid().ToString() + Path.GetExtension(studentViewModel.StudentCard.Image.FileName);
                            string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\StudentImage");

                            using var fileStream = new FileStream(Path.Combine(imagePath, filename), FileMode.Create);
                            studentViewModel.StudentCard.Image.CopyTo(fileStream);

                            studentViewModel.StudentCard.ImageUrl = @"\images\StudentImage\" + filename;
                        }
                        else
                        {
                            studentViewModel.StudentCard.ImageUrl = "https://placehold.co/600x402";
                        }
                        studentViewModel.StudentCard.Status = SD.StatusPending;
                        studentViewModel.StudentCard.Course = student.Course.CourseName;
                        _unitOfWork.StudentCard.Add(studentViewModel.StudentCard);
                        _unitOfWork.Save();
                        TempData["success"] = "The Student has been created successfully.";
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {

                        TempData["error"] = "Year must be the Current Year";
                        return View();
                    }
                }
                else
                {
                    TempData["error"] = "Student Not Registered";
                    return View();
                }

            }


        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            
            var studentCard = _unitOfWork.StudentCard.Get(u => u.Id == id, includeProperties: "Student");

            return View(studentCard);
        }
        [HttpPost]
        public IActionResult Delete(StudentCard studentViewModel)
        {
            StudentCard objfromDb = _unitOfWork.StudentCard.Get(x => x.Id == studentViewModel.Id,includeProperties:"Student");
            if (objfromDb is not null)
            {
                _unitOfWork.StudentCard.Remove(objfromDb);
                _unitOfWork.Save();
                TempData["success"] = "The Student has been deleted successfully.";
                return RedirectToAction("Index", "Home");
            }
            TempData["error"] = "The Student can not be deleted.";
            return View();
        }



        [HttpGet]
        public IActionResult Update(string id)
        {
            StudentCard objfromDb = _unitOfWork.StudentCard.Get(x => x.StudentID == id,includeProperties:"Student");
           
            return View(objfromDb);
        }
        
        [HttpPost]
        public IActionResult Update(StudentCard studentViewModel)
        {
            StudentCard objfromDb = _unitOfWork.StudentCard.Get(x => x.StudentID == studentViewModel.StudentID,includeProperties:"Student");
            objfromDb.Status = studentViewModel.Status;
            if (objfromDb is not null)
            {
                _unitOfWork.StudentCard.Update(objfromDb);
                _unitOfWork.Save();
                TempData["success"] = "The Student has been updated successfully.";
                return RedirectToAction("Index", "Home");
            }
            TempData["error"] = "The Student can not be updated.";
            return View();
        }

    }
}
