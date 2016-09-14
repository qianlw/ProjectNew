using Epoint.PingBiao.IService;
using Epoint.PingBiao.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Epoint.PingBiao.DAL;

namespace Epoint.PingBiao.Service  
{ 
	public partial class PingBiao_BiaoDuanService : BaseService<PingBiao_BiaoDuan> , IPingBiao_BiaoDuan
	{

        public PingBiao_BiaoDuan GetByBiaoDuanGuid(string BiaoDuanGuid)
        {
            using (var pbDbContext=new PBDbContext())
            {
                return pbDbContext.Set<PingBiao_BiaoDuan>().Find(BiaoDuanGuid);
            }
        }
    }
}