using CustomUrlAndHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomUrlAndHelper.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View(new List<User>() { new User {Id=1,Name="zahid",Description="check" } });
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            return View(new User { Id = 1, Name = "zahid", Description = "check" });
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            return View(new User { Id = 1, Name = "zahid", Description = "check" });
        }

        [HttpPost]
        public ActionResult Delete(User user)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int Id)
        {
            return View(new User { Id = 1, Name = "zahid", Description = "check" });
        }
    }
}