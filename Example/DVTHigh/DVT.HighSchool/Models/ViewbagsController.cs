using DVT.SchoolLibrary.BusinessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVT.HighSchool.Models
{
    public class ViewbagsController : Controller
    {
        // GET: Viewbags
        public void GenderViewbag(int? id = null)
        {
            DvtSchoolContext db = new DvtSchoolContext();
            ViewBag.GenderId = new SelectList(db.Genders.ToArray(), "genderId", "genderType", id);
            ViewBag.UserTypeId = new SelectList(db.UserTypes.ToArray(), "UserTypeId", "TypeName");
        }
    }
}