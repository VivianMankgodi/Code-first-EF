using DVT.SchoolLibrary.BusinessLayer.Context;
using DVT.SchoolLibrary.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVT.HighSchool.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public void Usertype(int? id = null)
        {
            DvtSchoolContext db = new DvtSchoolContext();

            ViewBag.UserId = new SelectList(db.UserTypes.ToArray(), "UsesrTypeId", "TypeName");
        }
        public ActionResult Index(string usertype)
        {
            Usertype();

            var list = new List<UserType>();
            if (string.IsNullOrWhiteSpace(usertype ))
            {
                return View(list );

            }
            if (usertype == "Teacher")
            {
                return RedirectToAction("Index", "Teacher");
            }
             if (usertype == "Learner")
            {
                return RedirectToAction("Index", "Learner");
            }
            return View();//("Index", "Learner");
        }
    }
}