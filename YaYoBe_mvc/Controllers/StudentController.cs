using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YaYoBe_mvc.Models;

namespace YaYoBe_mvc.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepository _Yayobe = new StudentRepository();
        // GET: Student
        public ActionResult List()
        {
            List<Student> s = new List<Student>();
            s = _Yayobe.GetAllStudents();
            return View(s);
            //return RedirectToAction("Faculty");
        }
    }
}