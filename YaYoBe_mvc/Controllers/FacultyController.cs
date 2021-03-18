using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YaYoBe_mvc.Models;

namespace YaYoBe_mvc.Controllers
{
    public class FacultyController : Controller
    {
        IFacultyRepository _Yayabe = new FacultyRepository();

        //IStudentRepository _Yayobe = new StudentRepository();
        // GET: Faculty
        public ActionResult Faculty()
        {
            List<Faculty> f = new List<Faculty>();
           f = _Yayabe.GetAllFaculty();
            return View(f);
        }
    }
}