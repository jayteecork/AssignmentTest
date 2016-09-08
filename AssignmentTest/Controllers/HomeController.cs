using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssignmentTest.DAL;
using AssignmentTest.ViewModels;


namespace AssignmentTest.Controllers

{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();


        public ActionResult Index()
        {

           ViewBag.loggedIn = "No";

            ViewBag.role = "None";

            if (User.Identity.IsAuthenticated)
            {
                ViewBag.loggedIn = "Authenticated";

                if (User.IsInRole("Admin"))
                {

                    ViewBag.role = "Admin";
                }
                if (User.IsInRole("Student"))
                {

                    ViewBag.role = "Student";
                }
                if (User.IsInRole("Staff"))
                {

                    ViewBag.role = "Staff";
                }
            }

           

            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult adminPrivate()
        {

            return View();
        }

        public ActionResult About()
        {
            IQueryable<EnrollmentDateGroup> data = from student in db.Students
                                                   group student by student.EnrollmentDate into dateGroup
                                                   select new EnrollmentDateGroup()
                                                   {
                                                       EnrollmentDate = dateGroup.Key,
                                                       StudentCount = dateGroup.Count()
                                                   };
            return View(data.ToList());
           

          
        }
      


    public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }

}