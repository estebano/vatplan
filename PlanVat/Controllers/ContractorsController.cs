﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlanVat.Controllers
{
    public class ContractorsController : Controller
    {
        // GET: Contractors
        public ActionResult Index()
        {
            return View();
        }

        // GET: Contractors/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contractors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contractors/Create
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

        // GET: Contractors/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contractors/Edit/5
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

        // GET: Contractors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contractors/Delete/5
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
