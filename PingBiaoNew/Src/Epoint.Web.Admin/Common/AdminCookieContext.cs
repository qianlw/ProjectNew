﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Epoint.Core.Cache;
using Epoint.Framework.Utility;

namespace Epoint.Web.Admin.Common
{
    public class AdminCookieContext : CookieContext
    {
        public static AdminCookieContext Current
        {
            get
            {
                return CacheHelper.GetItem<AdminCookieContext>();
            }
        }

        public override string KeyPrefix
        {
            get
            {
                return Fetch.ServerDomain + "_AdminContext_";
            }
        }
    }
}