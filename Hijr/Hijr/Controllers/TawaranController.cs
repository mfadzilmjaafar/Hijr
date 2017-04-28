using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hijr.Controllers
{
    public class TawaranController : Controller
    {
        // GET: Tawaran
        public ActionResult Index()
        {
            return View();
        }

        

        // GET: Tawaran/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tawaran/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tawaran/Create
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

        // GET: Tawaran/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tawaran/Edit/5
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

        // GET: Tawaran/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tawaran/Delete/5
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
