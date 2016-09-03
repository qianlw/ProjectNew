namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_MathErrors
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
        public string BiaoDuanGuid { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string Formula { get; set; }

        [StringLength(255)]
        public string TSXX { get; set; }

        [StringLength(255)]
        public string ErrorDW { get; set; }

        [Column(TypeName = "ntext")]
        public string Name { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CalTotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZhengPrice { get; set; }

        [StringLength(50)]
        public string ISTiaoZheng { get; set; }

        [StringLength(50)]
        public string ErrorType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverheadUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Profit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LaborUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialUnitPrice { get; set; }

        [StringLength(50)]
        public string TiaoZhengFS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MachineUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RiskUnitPrice { get; set; }
    }
}
