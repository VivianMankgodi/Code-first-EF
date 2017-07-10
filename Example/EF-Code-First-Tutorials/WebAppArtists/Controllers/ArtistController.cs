using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppArtists.Models;

namespace WebAppArtists.Controllers
{
    public class ArtistController : Controller
    {
        MusicStoredContext dbcontext = new MusicStoredContext();
        // GET: Artist
        public ActionResult Index()
        {
            return View(dbcontext.Artists.ToList());
        }

        public ActionResult Create()
        { return View(); }

        [HttpPost ]
        public ActionResult Create(Artist artist)
        {
            if (!ModelState.IsValid) return View(artist);
           
            dbcontext.Artists.Add(artist);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}