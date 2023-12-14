using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Card.Interface;
using Student_Card.Models;
using Student_Card.ViewModel;

namespace Student_Card.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        public AccountController(UserManager<ApplicationUser> usermanager, SignInManager<ApplicationUser> signinManager, RoleManager<IdentityRole> roleManager, IUnitOfWork unitOfWork)
        {
            _usermanager = usermanager;
            _signinManager = signinManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            LoginVM loginVM = new()
            {
                RedirectUrl = returnUrl,
            };
            return View(loginVM);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _signinManager.
                     PasswordSignInAsync(loginVM.Email, loginVM.Password, loginVM.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginVM.RedirectUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return LocalRedirect(loginVM.RedirectUrl);
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attept.");
                    TempData["error"] = $"{result.Succeeded}";
                }
            }

            return View(loginVM);
        }
        [HttpGet]
        public IActionResult Register()
        {
            if (!_roleManager.RoleExistsAsync(SD.Role_Admin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).Wait();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Student)).Wait();
            }
            RegisterViewM registerVM = new()
            {
                CourseList = _unitOfWork.Course.GetAll().Select(u => new SelectListItem
                {
                    Text = u.CourseName,
                    Value = u.ID.ToString(),
                }),
                Roles = _roleManager.Roles.Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Text = x.Name,
                    Value = x.Name

                }),

            };
            return View(registerVM);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewM registerViewM)
        {
            Student student = new()
            {
                Student_Number = registerViewM.RegisterVM.StudentNumber,
                CourseId = registerViewM.RegisterVM.CourseNumber,
                Title = registerViewM.RegisterVM.Title,
                Initials = registerViewM.RegisterVM.Initials,
                Surname = registerViewM.RegisterVM.Surname
            };
            bool StudentExists = _unitOfWork.Student.Any(u => u.Student_Number == student.Student_Number);
            if (ModelState.IsValid && !StudentExists && student.Student_Number.Length==9)
            {
                ApplicationUser user = new()
                {
                    UserName = registerViewM.RegisterVM.Email,
                    Email = registerViewM.RegisterVM.Email,
                    NormalizedEmail = registerViewM.RegisterVM.Email,
                    EmailConfirmed = true,
                    CourseNumber = registerViewM.RegisterVM.CourseNumber,
                    Initials = registerViewM.RegisterVM.Initials,
                    Surname = registerViewM.RegisterVM.Surname,
                    Title = registerViewM.RegisterVM.Title,
                    StudentNumber = registerViewM.RegisterVM.StudentNumber,
                    CreatedDate = DateTime.Now,
                    Role = registerViewM.Role
                };
                _unitOfWork.Student.Add(student);
                _unitOfWork.Save();
                TempData["success"] = "The Student has been created successfully.";
                var result = await _usermanager.CreateAsync(user, registerViewM.RegisterVM.Password);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(registerViewM.Role))
                    {
                        await _usermanager.AddToRoleAsync(user, registerViewM.Role);
                    }
                    else
                    {
                        await _usermanager.AddToRoleAsync(user, SD.Role_Student);
                    }

                    await _signinManager.SignInAsync(user, isPersistent: false);
                    if (string.IsNullOrEmpty(registerViewM.RegisterVM.RedirectUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return LocalRedirect(registerViewM.RegisterVM.RedirectUrl);
                    }

                }
                else
                {
                    TempData["error"] = "Invalid student number try again with vaild student number.";
                }
            }
            registerViewM.Roles =

                 _roleManager.Roles.Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                 {
                     Text = x.Name,
                     Value = x.Name

                 });
            return View(registerViewM);
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Details(ApplicationUser user)
        {
            ApplicationUser obj = _unitOfWork.User.Get(x => x.UserName == user.UserName);
            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }
        public IActionResult AccessDenied()
        {

            return View();
        }
    }
}
