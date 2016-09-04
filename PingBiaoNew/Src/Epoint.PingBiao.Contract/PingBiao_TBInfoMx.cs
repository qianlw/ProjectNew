namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TBInfoMx : ModelBase
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(500)]
        public string BookMarkName { get; set; }

        public int? Xh { get; set; }

        [StringLength(500)]
        public string MarkValue { get; set; }

        [StringLength(50)]
        public string MarkType { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(500)]
        public string DanWeiName { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [StringLength(200)]
        public string Attribute1 { get; set; }

        [StringLength(50)]
        public string Attribute2 { get; set; }
    }
}
