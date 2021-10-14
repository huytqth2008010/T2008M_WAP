﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2008M_WAP.Models;
namespace T2008M_WAP.Controllers
{
    public class CategoryController : Controller
    {
        private DataContext context = new DataContext();
        // GET: Category
        public ActionResult Index()
        {
            return View(context.Categories.ToList());
        }

        // Details Category
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Category category = context.Categories.Find(id);
            if(category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
        //

        // Create Category
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="Id,Name")]Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);//Them 1 object vao list
                context.SaveChanges();// Luu vao db
                return RedirectToAction("Index");

            }
            return View(category);
        }
        //

        //Edit Category
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Category category = context.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include ="Id,Name")]Category category)
        {
            if (ModelState.IsValid)
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;// bao trong thai chinh sua
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }
        //

        //Delete Category
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Category category = context.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //
    }
}