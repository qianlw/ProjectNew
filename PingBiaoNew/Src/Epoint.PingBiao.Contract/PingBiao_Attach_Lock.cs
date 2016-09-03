namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Attach_Lock : ModelBase
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        public int Row_ID { get; set; }

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(50)]
        public string AttachGuid { get; set; }

        [StringLength(50)]
        public string LockUserGuid { get; set; }

        [StringLength(50)]
        public string LockUserName { get; set; }

        [StringLength(50)]
        public string LockDate { get; set; }

        [StringLength(1)]
        public string IsLock { get; set; }
    }
}
