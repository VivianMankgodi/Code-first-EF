using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_First_Artist.Models;

namespace Code_First_Artist.Controllers
{
    public class ArtistController : Controller
    {

        //calling db context class
        MusicStoredDataContext dbcontext = new MusicStoredDataContext();

        // GET: Artist
        public ActionResult Index()
        {
            //lesting all the list of music
            return View(dbcontext.Aritits.ToList());
        }
    }
}