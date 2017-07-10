using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppArtist.Models;

namespace WebAppArtist.Controllers
{
    public class ArtistController : Controller
    {
        //calling db context class
        MusicStoredDataContext dbcontext = new MusicStoredDataContext();

        // GET: Artist
        public ActionResult Index()
        {
            //lesting all the list of music
            return View(dbcontext.Artists.ToList());

        }
    }
}