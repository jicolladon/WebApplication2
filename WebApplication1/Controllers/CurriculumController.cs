﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CurriculumController : BaseController
    {
        //
        // GET: /Curriculum/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Curriculum/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Curriculum/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Curriculum/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Curriculum/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Curriculum/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Curriculum/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Curriculum/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
