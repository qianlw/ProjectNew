namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_FileTender : ModelBase
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

        public int? TenderLx { get; set; }

        [StringLength(255)]
        public string TenderName { get; set; }

        [StringLength(10)]
        public string Xh { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        public int? FileLx { get; set; }
    }
}
