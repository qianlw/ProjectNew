namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_FormulaList
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

        public int? BidId { get; set; }

        [StringLength(255)]
        public string BidName { get; set; }

        [StringLength(255)]
        public string BidFormula { get; set; }

        [StringLength(255)]
        public string FormulaKoufen { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Selected { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalMark { get; set; }

        [Column(TypeName = "ntext")]
        public string ZongHeDJDetail { get; set; }

        [StringLength(50)]
        public string EconType { get; set; }

        [StringLength(50)]
        public string Mark { get; set; }

        [StringLength(50)]
        public string PFDType { get; set; }

        public int? OrderNum { get; set; }

        [StringLength(200)]
        public string PFDName { get; set; }

        public int? IsMustPass { get; set; }

        [StringLength(50)]
        public string PingFenMethod { get; set; }

        [StringLength(200)]
        public string PFDMapUrl { get; set; }

        [StringLength(50)]
        public string XH { get; set; }

        [StringLength(1)]
        public string IsZJF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MustMark { get; set; }

        [StringLength(1)]
        public string AutoCalc { get; set; }

        [StringLength(250)]
        public string PFDDangCi { get; set; }

        [StringLength(300)]
        public string BidFormulaParams { get; set; }

        [StringLength(300)]
        public string FormulaKouFenParams { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? D1Min { get; set; }

        [StringLength(50)]
        public string D1Max { get; set; }

        public int? PWS { get; set; }

        [StringLength(50)]
        public string PFDGuid { get; set; }

        [StringLength(300)]
        public string ZongHeUnitPriceFormula { get; set; }

        [Column(TypeName = "ntext")]
        public string ZongHeUnitPrice_Params { get; set; }

        [StringLength(500)]
        public string ZhiGeFormulaParam { get; set; }

        [StringLength(50)]
        public string ZGSCType { get; set; }

        [StringLength(500)]
        public string ZhiGeFormula { get; set; }

        [StringLength(500)]
        public string PFDMapDesp { get; set; }

        [StringLength(50)]
        public string PFDMapType { get; set; }
    }
}
