using PlanVat.Domain.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace PlanVat.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products/Create
        public ActionResult Create()
        {
            using (var context = new VatplanEntities())
            {
                PrepareProductSelectDatas(context);
            }
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Products product)
        {
            using (var context = new VatplanEntities())
            {
                try
                {
                    // TODO: Add insert logic here
                    context.Products.Add(product);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    PrepareProductSelectDatas(context);
                    return View();
                }
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            using(var context = new VatplanEntities())
            {
                var product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        // POST: Products/Delete/5
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

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            using(var context = new VatplanEntities())
            {
                PrepareProductSelectDatas(context);
                return View(context.Products.Find(id));
            }
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Products product)
        {
            using (var context = new VatplanEntities())
            {
                try
                {
                    context.Entry(product).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch(Exception e)
                {
                    PrepareProductSelectDatas(context);
                    return View();
                }
            }
        }

        // GET: Products
        public ActionResult Index()
        {
            return GetIndexView();
        }

        private void PrepareProductSelectDatas(VatplanEntities context)
        {
            ViewData["UnitsId"] = new SelectList(context.UnitsOfMeasure.ToList(), "Id", "Name");
            ViewData["VatRateId"] = new SelectList(context.VatRates.ToList(), "Id", "Name");
        }

        private ActionResult GetIndexView()
        {
            using (var context = new VatplanEntities())
            {
                var products = from p in context.Products
                               .Include(p => p.UnitsOfMeasure)
                               .Include(p => p.VatRates)
                               select p;

                return View("Index", products.ToList());
            }
        }
    }
}
