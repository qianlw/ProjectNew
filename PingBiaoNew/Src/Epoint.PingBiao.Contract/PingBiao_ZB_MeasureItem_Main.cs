namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_MeasureItem_Main
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

        [StringLength(50)]
        public string Xh { get; set; }

        [StringLength(255)]
        public string Mc { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(255)]
        public string Jsjc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fl { get; set; }

        [StringLength(50)]
        public string Xmlb { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }
    }
}
