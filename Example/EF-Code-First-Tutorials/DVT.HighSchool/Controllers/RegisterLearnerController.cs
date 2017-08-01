using DVT.SchoolLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DVT.SchoolLibrary.Context;


namespace DVT.HighSchool.Controllers
{
    public class RegisterLearnerController : Controller
    {
        private LearnerRepo repo = new LearnerRepo();

        private GenderRepo GRepo = new GenderRepo();
        // GET: RegisterLearner
        public ActionResult Index()
        {
            return View(repo.GetAll().ToList());
           
        }

        public ActionResult  Genders()
        {
           // var result = GRepo.GetAll().ToList();
            return View(GRepo.GetAll().ToList());
        }
        public string  indexs()
        {
            var  result= repo.GetAll().ToList();
            return  result.ToString();
        }
    }
}