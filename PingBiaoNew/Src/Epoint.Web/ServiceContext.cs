using System;
using System.Collections.Generic;
using Epoint.Account.Contract;
using Epoint.Core.Cache;
using Epoint.Core.Service;
using Epoint.Cms.Contract;
using Epoint.Crm.Contract;
using Epoint.PingBiao.IService;

namespace Epoint.Web
{
    public class ServiceContext
    {
        public static ServiceContext Current
        {
            get
            {
                return CacheHelper.GetItem<ServiceContext>("ServiceContext", () => new ServiceContext());
            }
        }
        
        public IAccountService AccountService
        {
            get
            {
                return ServiceHelper.CreateService<IAccountService>();
            }
        }

        public ICmsService CmsService
        {
            get
            {
                return ServiceHelper.CreateService<ICmsService>();
            }
        }

        public ICrmService CrmService
        {
            get
            {
                return ServiceHelper.CreateService<ICrmService>();
            }
        }

        public IPingBiao_BiaoDuan PingBiao_BiaoDuanService
        {
            get
            {
                return ServiceHelper.CreateService<IPingBiao_BiaoDuan>();
            }
        }

        
    }
}
