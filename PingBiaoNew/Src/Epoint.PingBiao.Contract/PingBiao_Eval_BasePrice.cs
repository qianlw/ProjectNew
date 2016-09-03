namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_BasePrice
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

        [StringLength(255)]
        public string BiaoDuanGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_BiaoDi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice_Avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_Avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice_CiLeast { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_CiLeast { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice_Least { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_Least { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice_Max { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_Max { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice_BiaoDi { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(200)]
        public string DanWeiGuid { get; set; }

        [StringLength(200)]
        public string QingDanNO { get; set; }
    }
}
