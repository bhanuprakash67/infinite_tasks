using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Code_Challenge_2_que.Models;
using MVC_Code_Challenge_2_que.Repository;

namespace MVC_Code_Challenge_2_que.Controllers
{
    public class MoviesControllerController : Controller
    {
        MovieName mn= new MovieName(new MovieContext());

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movies m)
        {
            if (ModelState.IsValid)
            {
                mn.Insert(m);
                mn.Save();
                return RedirectToAction("Index");
            }
            return View(m);
        }

        public ActionResult Edit(int id)
        {
            var movie = mn.GetById(id);
            if (movie == null) return HttpNotFound();
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movies m)
        {
            if (ModelState.IsValid)
            {
                mn.Update(m);
                mn.Save();
                return RedirectToAction("Index");
            }
            return View(m);
        }



        public ActionResult Index()
        {
            var movies = mn.GetAll();
            return View(movies);
        }
    }
}