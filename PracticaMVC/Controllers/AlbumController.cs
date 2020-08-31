using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaMVC.Models;

namespace PracticaMVC.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album

        List<AlbumCLS> ListaAlbum = null;
        public ActionResult Index()
        {

            using (var bd = new musicmanEntities())
            {


                ListaAlbum = (List<AlbumCLS>)(from i in bd.Albums
                                              select new AlbumCLS
                                              {
                                                  AlbumName = i.AlbumName,
                                                  DateReleased = (DateTime)i.DateReleased,
                                                  ArtistID = (int)i.ArtistID,
                                                  GenreID = (int)i.GenreID

                                              });


            }
            return View(ListaAlbum);
        }
    }
}