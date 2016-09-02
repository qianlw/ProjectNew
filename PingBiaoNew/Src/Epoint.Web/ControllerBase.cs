using System;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using Epoint.Account.Contract;
using Epoint.Framework.Web;
using Epoint.Framework.Contract;
using Epoint.Core.Log;
using Epoint.Cms.Contract;
using Epoint.Crm.Contract;
using Epoint.PingBiao.IService;

namespace Epoint.Web
{
    public abstract class ControllerBase : Epoint.Framework.Web.ControllerBase
    {
        public virtual IAccountService AccountService
        {
            get
            {
                return ServiceContext.Current.AccountService;
            }
        }

        public virtual ICmsService CmsService
        {
            get
            {
                return ServiceContext.Current.CmsService;
            }
        }

        public virtual ICrmService CrmService
        {
            get
            {
                return ServiceContext.Current.CrmService;
            }
        }

        public virtual IPingBiao_BiaoDuan PingBiao_BiaoDuanService
        {
            get
            {
                return ServiceContext.Current.PingBiao_BiaoDuanService;
            }
        }
                

        protected override void LogException(Exception exception, 
            WebExceptionContext exceptionContext = null)
        {
            base.LogException(exception);

            var message = new
            {
                exception = exception.Message,
                exceptionContext = exceptionContext,
            };

            Log4NetHelper.Error(LoggerType.WebExceptionLog, message, exception);
        }

        public IDictionary<string, object> CurrentActionParameters { get; set; }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }
}
