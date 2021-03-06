﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*using Channel6.Domain.Entities;
using Channel6.Domain.Concrete;
using System.Security.Claims;
using System.Data.Entity;

namespace Channel6.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public static string date_posted = "";
        public static string time_posted = "";
        public ActionResult Index()
        {
            var db = new EFDbContext();
            return View(db.Lists.ToList());
        }

        [HttpPost]
        public ActionResult Index(List list)
        {
            if (ModelState.IsValid)
            {
                string timeToday = DateTime.Now.ToString("h:mm:ss tt");
                string dateToday = DateTime.Now.ToString("M/dd/yyyy");

                using (var db = new EFDbContext())
                {
                    Claim sessionEmail = ClaimsPrincipal.Current.FindFirst(ClaimTypes.Email);
                    string userEmail = sessionEmail.Value;
                    var userIdQuery = db.Users.Where(u => u.Email == userEmail).Select(u => u.Id);
                    var userId = userIdQuery.ToList();
                    string check_public = Request.Form["check_public"];
                    string new_item = Request.Form["new_item"];

                    var dbList = db.Lists.Create();
                    dbList.Details = new_item;
                    dbList.Date_Posted = dateToday;
                    dbList.Time_Posted = timeToday;
                    dbList.User_Id = userId[0];
                    if (check_public != null) { dbList.Public = "YES"; }
                    else { dbList.Public = "NO"; }
                    db.Lists.Add(dbList);
                    db.SaveChanges();
                }
            }
            else
            {
                ModelState.AddModelError("", "Incorrect format has been placed");
            }

            var listTable = new EFDbContext();
            return View(listTable.Lists.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new EFDbContext();
            var model = new List();
            model = db.Lists.Find(id);
            date_posted = model.Date_Posted;
            time_posted = model.Time_Posted;
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(List list)
        {
            var db = new EFDbContext();
            string timeToday = DateTime.Now.ToString("h:mm:ss tt");
            string dateToday = DateTime.Now.ToString("M/dd/yyyy");
            string new_item = Request.Form["new_item"];
            string check_public = Request.Form["check_public"];

            if (ModelState.IsValid)
            {
                list.Time_Edited = timeToday;
                list.Date_Edited = dateToday;
                list.Details = new_item;
                list.Time_Posted = time_posted;
                list.Date_Posted = date_posted;
                if (check_public != null) { list.Public = "YES"; }
                else { list.Public = "NO"; }

                db.Entry(list).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(list);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var db = new EFDbContext();
            var model = db.Lists.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            db.Lists.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
*/