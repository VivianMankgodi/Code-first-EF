using DVT.HighSchool.Models;
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
    public class LearnerController : Controller
    {
        // GET: Learner
        LearnerRepo  LRepo = new LearnerRepo();
        GenderRepo GRepo = new GenderRepo();
        DvtSchoolContext db = new DvtSchoolContext();
        public ActionResult Index()
        {
            var query = LRepo.GetAll().ToList();
            return View(query );
        }

        public void GenderViewbag(int? id =null )
        {
            DvtSchoolContext db = new DvtSchoolContext();
            ViewBag.GenderId = new SelectList(db.Genders.ToArray(), "genderId", "genderType", id);
            ViewBag.UserTypeId = new SelectList(db.UserTypes.ToArray(), "UserTypeId", "TypeName");
        }
        public ActionResult Create()
        {
            /*ViewBag.GenderSelection = db.Genders.Select(g => new SelectListItem
            {
                Value = g.GenderId.ToString(),
                Text = g.GenderType
            }); */

            GenderViewbag();
            //ViewbagsController theview = new ViewbagsController();
           // theview.GenderViewbag();
            return View();
        }
        [HttpPost ]
        public ActionResult Create(Learner learner)
        {
            //if (ModelState.IsValid )
            //{
         //   if (learner.GenderId > 0)
           // {
             //   learner.Gender = GetGenderByID(learner.GenderId);
            //}

                LRepo.Inserting(learner);
                LRepo.SaveChange();
                return RedirectToAction("Index");
            //}
            //else
            //{
            //    //  GRepo.GetAll

               
            //    IEnumerable<SelectListItem> basetypes = db.Genders.Select(g => new SelectListItem { Value = g.GenderType , Text = g.GenderType });
            //    ViewData["gender"] = basetypes;
            //    return View(learner);
            //}

           
        }

        private Gender GetGenderByID(int genderId)
        {
            throw new NotImplementedException();
        }
    }
}