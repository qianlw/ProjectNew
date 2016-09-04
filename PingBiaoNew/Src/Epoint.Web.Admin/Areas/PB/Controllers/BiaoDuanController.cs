using Epoint.Account.Contract;
using Epoint.PingBiao.IService;
using Epoint.PingBiao.Service;
using Epoint.Web.Admin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Epoint.Framework.Contract;

namespace Epoint.Web.Admin.Areas.PB.Controllers
{
    [Permission(EnumBusinessPermission.PBManage_Staff)]
    public class BiaoDuanController : AdminControllerBase
    {
        IPingBiao_BiaoDuan iPingBiao_BiaoDuan = new PingBiao_BiaoDuan();
        //
        // GET: /PB/BiaoDuan/

        public ActionResult Index(Request request)
        {
            var result = iPingBiao_BiaoDuan.GetListBy(p => p.BiaoDuanName != null,m=>m.ID).ToPagedList(request.PageIndex,request.PageSize);
            
            //var result = this.PingBiao_BiaoDuanService.GetListBy(p => p.BiaoDuanName != null);
            return View(result);
        }

        //
        // GET: /PB/BiaoDuan/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PB/BiaoDuan/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PB/BiaoDuan/Create

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
        // GET: /PB/BiaoDuan/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PB/BiaoDuan/Edit/5

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
        // GET: /PB/BiaoDuan/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PB/BiaoDuan/Delete/5

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
