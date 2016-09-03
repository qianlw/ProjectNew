namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_MeasureItemDEZJ
    {
        [StringLength(50)]
        public string MeasureItemId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zcf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fcf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MachineUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverheadUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Profit { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(255)]
        public string DingeNO { get; set; }

        [StringLength(500)]
        public string DingeName { get; set; }

        [StringLength(80)]
        public string Unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LaborUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RiskUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeTotalPrice { get; set; }

        public int? DingeDyId { get; set; }

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

        [StringLength(2)]
        public string ISBiaoDi { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DergfDj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DergfHj { get; set; }
    }
}
