using DVT.SchoolLibrary.BusinessLayer.Context;
using DVT.SchoolLibrary.BusinessLayer.Models;
using DVT.SchoolLibrary.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVT.HighSchool.Controllers
{
    public class TeacherController : Controller
    {
        TeacherRepo repo = new TeacherRepo();

        // GET: Teacher
        public ActionResult Index()
        {
            var query = repo.GetAll().ToList();
            return View(query);
        }

        public ActionResult Create()
        {
            ViewBagSelecting();
            return View();
        }

        [HttpPost ]
        public ActionResult Create(Teacher teacher)
        {
            repo.Inserting(teacher);
            repo.SaveChange();

            return View("Index", repo.GetAll().ToList());
        }

        public void ViewBagSelecting(int? id = null)
        {
            DvtSchoolContext db = new DvtSchoolContext();
            ViewBag.GenderId = new SelectList(db.Genders.ToArray(), "genderId", "genderType", id);
            ViewBag.UserTypeId = new SelectList(db.UserTypes.ToArray(), "UserTypeId", "TypeName");
        }
    }
}