﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Lesson10paro.Models;

namespace COMP2007_S2016_Lesson10paro.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Genre> genres = new List<Genre>
            {
                 new Genre("Disco"),
                 new Genre("Jazz"),
                 new Genre("Rock")
            };

            return View(genres);
        }
        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre(genre);

            return View(genreModel);
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id = 1)
        {
            Album album = new Album("Album " + id);

            return View(album);
        }
    }
}