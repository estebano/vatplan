using PlanVat.Domain.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlanVat.Infrastructure;
using PlanVat.Models;

namespace PlanVat.Controllers
{
    public class ContractorsController : LoggingController
    {
        // GET: Contractors
        public ActionResult Index()
        {
            using (var context = new VatplanEntities())
            {
                var contractors = from c in context.Contractors
                                  select c;
                return View(contractors.ToList());
            }
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
        public ActionResult Create(ContractorViewModel contractor)
        {
            if (contractor == null)
            {
                throw new ArgumentNullException(nameof(contractor));
            }

            Log.Debug("Test debug message");

            using (var context = new VatplanEntities())
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        // TODO: Add insert logic here
                        context.Contractors.Add(contractor.ToDTO());
                        context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception ex)
                {
                    Log.Debug("Saving model error", ex);
                }
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
