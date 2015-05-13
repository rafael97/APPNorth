using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Web;
using System.Web.Mvc;
using App.Models;

namespace App.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/
        private NORTHWNDEntities db = new NORTHWNDEntities();

        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Categories).Include(p => p.Suppliers);
            return View(products.ToList());
            
        }

        //
        // GET: /Products/Details/5

        public ActionResult Details(int id)
        {
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        //
        // GET: /Products/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Products/Create

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
        // GET: /Products/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Products/Edit/5

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
        // GET: /Products/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Products/Delete/5

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
