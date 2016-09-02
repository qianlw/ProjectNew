﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epoint.Framework.Contract
{
    public class ModelBase
    {
        public ModelBase()
        {
            CreateTime = DateTime.Now;
        }

        public virtual int ID { get; set; }
        public virtual DateTime CreateTime { get; set; }
    }
}
