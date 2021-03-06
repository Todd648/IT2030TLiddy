﻿using MVCMusicStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: Store
        public ActionResult Index(int id)
        {
            

            return View(GetAlbums(id));
        }

        private List<Album> GetAlbums(int id)
        {
            return db.Albums
                .Where(a => a.GenreId == (id))
                .ToList();
        }

        // GET: Browse
        public ActionResult Browse()
        {
            
            return View(db.Genres.ToList());
        }

        // GET: Store
        public ActionResult Details(int id)
        {
            return View(GetDetails(id));
        }

        private List<Album> GetDetails(int id)
        {
            return db.Albums
                .Where(a => a.AlbumId == (id))
                .ToList();
        }

        // GET: ShoppingCart
        public ActionResult ShoppingCart()
        {
            return View();
        }

        // GET: ShoppingCart/AddToCart
        public ActionResult AddToCart(int id)
        {
            return null;
        }
		public ActionResult DailyDeal()
		{
			var DailyDeal = getDailyDeal();
			return PartialView("DailyDeal", DailyDeal);
		}
		private Album getDailyDeal()
		{
			var dailydeal = db.Albums
				.OrderBy(a => Guid.NewGuid()).First();
			return dailydeal;
		}
		public ActionResult ArtistSearch(string q)
		{
			var artists = GetArtists(q);
			return PartialView(artists);
		}
		private List<Artist>GetArtists(string searchString)
		{
			return db.Artists
				.Where(a => a.Name.Contains(searchString))
				.ToList();
		}
    }
}