using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppArtists.Models;
using WebAppArtists.Models.Repositories;

namespace WebAppArtists.Controllers
{
    public class ArtistReposController : Controller
    {
        // GET: ArtistRepositories
        //here we call the  ArtistRepository class so that we can use its method that from Repository class
        ArtistRepository repository = new ArtistRepository();

        //here we will call the GetByName method to retun all rows that has name values
        public ActionResult Index()
        {
            //when we call  GetAll method from reposistory class to get all the Artist
            return View(repository.GetAll());
        }

        //using Add and save method
        public ActionResult AddArtist()
        {
            return View();
        }
        [HttpPost ]
        public ActionResult AddArtist(Artist artist)
        {
            repository.Adds(artist);
            repository.SaveChange();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Artist FindArtist = repository.Get(id);
            if (FindArtist == null )
            {
                return HttpNotFound();
            }
            else
            {
                return View(FindArtist);
            }
        }
    }
}