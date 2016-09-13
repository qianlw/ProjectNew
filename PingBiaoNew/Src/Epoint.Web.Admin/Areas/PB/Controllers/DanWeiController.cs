using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epoint.Web.Admin.Areas.PB.Controllers
{
    public class DanWeiController : Controller
    {
        //
        // GET: /PB/DanWei/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /PB/DanWei/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PB/DanWei/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PB/DanWei/Create

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
        // GET: /PB/DanWei/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PB/DanWei/Edit/5

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
        // GET: /PB/DanWei/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PB/DanWei/Delete/5

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
