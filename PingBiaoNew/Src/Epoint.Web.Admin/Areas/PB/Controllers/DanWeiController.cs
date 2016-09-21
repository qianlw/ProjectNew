using Epoint.Framework.Contract;
using Epoint.PingBiao.Contract;
using Epoint.PingBiao.IService;
using Epoint.PingBiao.Service;
using Epoint.Web.Admin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epoint.Web.Admin.Areas.PB.Controllers
{
    public class DanWeiController : AdminControllerBase
    {
        IPingBiao_KaiBiaoTouBiao idanwei = new PingBiao_KaiBiaoTouBiaoService();
        IPingBiao_BiaoDuan ibiaoDuan = new PingBiao_BiaoDuanService();
        //
        // GET: /PB/DanWei/

        public ActionResult Index(Request request)
        {
            var result = idanwei.GetListBy(p => p.BiaoDuanGuid == BiaoDuanGuid, m => m.ID).ToPagedList(request.PageIndex, request.PageSize);

            var biaoDuanInfo = ibiaoDuan.GetByBiaoDuanGuid(BiaoDuanGuid);
            ViewData["biaoDuanInfo"] = biaoDuanInfo;
            return View(result);
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
                PingBiao_KaiBiaoTouBiao kaibiaotb = new PingBiao_KaiBiaoTouBiao();
                kaibiaotb.DanWeiName = collection["DanWeiName"];
                kaibiaotb.RowGuid=Guid.NewGuid().ToString();
                kaibiaotb.DanWeiGuid = Guid.NewGuid().ToString();
                kaibiaotb.BiaoDuanGuid = BiaoDuanGuid;
                idanwei.Add(kaibiaotb);
                idanwei.Commit();
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
        public ActionResult Delete(List<int> ids)
        {
            try
            {
                idanwei.DelBy(u => ids.Contains(u.ID));
                idanwei.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult OpenKB()
        {
            ViewData["KaiBiaoTime"] = ibiaoDuan.GetListBy(p => p.BiaoDuanGuid == BiaoDuanGuid).FirstOrDefault().KaiBiaoDate;
            return View("KBBeiJing");
        }

    }
}
