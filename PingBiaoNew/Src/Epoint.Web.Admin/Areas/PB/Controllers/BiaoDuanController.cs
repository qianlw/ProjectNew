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
using Epoint.PingBiao.Contract;
using Epoint.Framework.Utility;

namespace Epoint.Web.Admin.Areas.PB.Controllers
{
    [Permission(EnumBusinessPermission.PBManage_Staff)]
    public class BiaoDuanController : AdminControllerBase
    {
        IPingBiao_BiaoDuan iPingBiao_BiaoDuan = new PingBiao_BiaoDuanService();
        //
        // GET: /PB/BiaoDuan/

        public ActionResult Index(BiaoDuanRequest request, bool? type)
        {
            //原方法实现
            List<PingBiao_BiaoDuan> result = iPingBiao_BiaoDuan.GetListBy(p=>p.BiaoDuanName!=null).ToList();
            
            //var whereLambda = string.Empty;
            if (type == true)
            {
                result = iPingBiao_BiaoDuan.GetListBy(p => p.KaiBiaoDate.Value.Year <= DateTime.Now.Year && p.KaiBiaoDate.Value.Month <= DateTime.Now.Month && p.KaiBiaoDate.Value.Day < DateTime.Now.Day, m => m.KaiBiaoDate).ToPagedList(request.PageIndex, request.PageSize);                
            }
            else if (type == false)
            {
                result = iPingBiao_BiaoDuan.GetListBy(p => p.KaiBiaoDate.Value.Year >= DateTime.Now.Year && p.KaiBiaoDate.Value.Month >= DateTime.Now.Month && p.KaiBiaoDate.Value.Day > DateTime.Now.Day, m => m.KaiBiaoDate).ToPagedList(request.PageIndex, request.PageSize);
            }
            else
            {
                result = iPingBiao_BiaoDuan.GetListBy(p => p.KaiBiaoDate.Value.Year == DateTime.Now.Year && p.KaiBiaoDate.Value.Month == DateTime.Now.Month && p.KaiBiaoDate.Value.Day == DateTime.Now.Day, m => m.KaiBiaoDate).ToPagedList(request.PageIndex, request.PageSize);

            }
            if (!string.IsNullOrEmpty(request.BiaoDuanName))
            {
                result = result.Where(p => p.BiaoDuanGuid.Contains(request.BiaoDuanName)).ToList();
            }
            
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
            var model = new PingBiao_BiaoDuan() { };
            return View("Edit", model);
        }

        //
        // POST: /PB/BiaoDuan/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var model = new PingBiao_BiaoDuan();
                this.TryUpdateModel<PingBiao_BiaoDuan>(model);

                iPingBiao_BiaoDuan.Add(model);

                return this.RefreshParent();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PB/BiaoDuan/Edit/5

        public ActionResult Edit(string guid)
        {
            var model = iPingBiao_BiaoDuan.GetByID(guid);
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
