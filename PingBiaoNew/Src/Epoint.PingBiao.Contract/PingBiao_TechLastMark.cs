namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TechLastMark
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        [Key]
        public int Row_ID { get; set; }

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(500)]
        public string PingWeiMarkReason { get; set; }

        [StringLength(50)]
        public string ZGZDType { get; set; }

        [StringLength(255)]
        public string Bz { get; set; }

        public DateTime? XiuGaiData { get; set; }

        [StringLength(50)]
        public string PingFenType { get; set; }

        [StringLength(50)]
        public string PingWeiMarkPass { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string PingWeiGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PingWeiMarkResult { get; set; }
    }
}
