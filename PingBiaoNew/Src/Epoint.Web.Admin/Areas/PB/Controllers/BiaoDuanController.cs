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
            var result = iPingBiao_BiaoDuan.GetListBy(p => p.BiaoDuanName != null);
            
            //var whereLambda = string.Empty;
            if (type == true)
            {
                result = iPingBiao_BiaoDuan.GetListBy(p => p.KaiBiaoDate.Value.Year <= DateTime.Now.Year && p.KaiBiaoDate.Value.Month <= DateTime.Now.Month && p.KaiBiaoDate.Value.Day < DateTime.Now.Day, m => m.KaiBiaoDate);                
            }
            else if (type == false)
            {
                result = iPingBiao_BiaoDuan.GetListBy(p => p.KaiBiaoDate.Value.Year >= DateTime.Now.Year && p.KaiBiaoDate.Value.Month >= DateTime.Now.Month && p.KaiBiaoDate.Value.Day > DateTime.Now.Day, m => m.KaiBiaoDate);
            }
            else
            {
                result = iPingBiao_BiaoDuan.GetListBy(p => p.KaiBiaoDate.Value.Year == DateTime.Now.Year && p.KaiBiaoDate.Value.Month == DateTime.Now.Month && p.KaiBiaoDate.Value.Day == DateTime.Now.Day, m => m.KaiBiaoDate);

            }
            if (!string.IsNullOrEmpty(request.BiaoDuanName))
            {
                result = result.Where(p => p.BiaoDuanName.Contains(request.BiaoDuanName));
            }
            var list = result.ToPagedList(request.PageIndex, request.PageSize);
            return View(list);
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
                iPingBiao_BiaoDuan.Commit();

                return this.RefreshParent();
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
            var model = iPingBiao_BiaoDuan.GetByID(id);
            return View(model);
        }

        //
        // POST: /PB/BiaoDuan/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var model = iPingBiao_BiaoDuan.GetByID(id);
                this.TryUpdateModel<PingBiao_BiaoDuan>(model);

                iPingBiao_BiaoDuan.Modify(model);
                iPingBiao_BiaoDuan.Commit();

                return this.RefreshParent();
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
        public ActionResult Delete(List<int> ids,bool? type,string BiaoDuanName)
        {
            try
            {
                iPingBiao_BiaoDuan.DelBy(u => ids.Contains(u.ID));
                iPingBiao_BiaoDuan.Commit();
                return RedirectToAction("Index", new { type = type, BiaoDuanName = BiaoDuanName });
            }
            catch
            {
                return View();
            }
        }
    }
}
