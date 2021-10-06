using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{

    public class StudentController : Controller
    {

        // GET: Student
        public ActionResult Create()
        {
            //fetch students from the DB using Entity Framework here

            return View();
        }
    }


}