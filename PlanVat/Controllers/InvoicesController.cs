using PlanVat.Domain.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace PlanVat.Controllers
{
    public class InvoicesController : Controller
    {
        // GET: Invoices
        public ActionResult Index()
        {
            using (var context = new VatplanEntities())
            {
                var invoices = from i in context.Invoices
                               .Include("InvoiceItems")
                               .Include("InvoiceItems.ProductsInInvoices")
                               .Include("InvoiceItems.ProductsInInvoices.VatRates")
                               .Include("InvoiceItems.ProductsInInvoices.UnitsOfMeasure")
                               select i;
                return View(invoices.ToList());
            }
        }

        // GET: Invoices/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Invoices/Create
        public ActionResult Create()
        {
            using (var context = new VatplanEntities())
            {
                ViewData["ContractorId"] = new SelectList(context.Contractors.ToList(), "Id", "Name");
                ViewData["NewProductName"] = new SelectList(context.Products.ToList(), "Id", "Name");
                var invoice = new Invoices();
                return View(invoice);
            }
        }

        // POST: Invoices/Create
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

        // GET: Invoices/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Invoices/Edit/5
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

        // GET: Invoices/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Invoices/Delete/5
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
