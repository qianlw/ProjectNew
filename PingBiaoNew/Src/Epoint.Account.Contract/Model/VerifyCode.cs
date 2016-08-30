using System;
using System.Linq;
using Epoint.Framework.Contract;
using System.Collections.Generic;
using Epoint.Framework.Utility;
using System.ComponentModel.DataAnnotations.Schema;

namespace Epoint.Account.Contract
{
    [Serializable]
    [Table("VerifyCode")]
    public class VerifyCode : ModelBase
    {
        public Guid Guid { get; set; }
        public string VerifyText { get; set; }
    }

}



