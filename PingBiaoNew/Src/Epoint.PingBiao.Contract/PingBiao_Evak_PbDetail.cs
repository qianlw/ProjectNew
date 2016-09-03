namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Evak_PbDetail
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

        public int? BidId { get; set; }

        public int? PFXId { get; set; }

        [StringLength(50)]
        public string TotalMark { get; set; }

        [StringLength(255)]
        public string BidFormula { get; set; }

        [Column(TypeName = "ntext")]
        public string ZongHeDjdetail { get; set; }

        [StringLength(255)]
        public string FormulaKouFen { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        [StringLength(50)]
        public string IsNegative { get; set; }

        [StringLength(50)]
        public string PFXType { get; set; }

        [StringLength(50)]
        public string EconType { get; set; }

        [StringLength(10)]
        public string Xh { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MinDF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxDF { get; set; }

        public int? EconomicPWS { get; set; }

        [StringLength(50)]
        public string IsSheZhiZHDJ { get; set; }

        public int? IsZJF { get; set; }

        public int? AutoCalc { get; set; }

        [StringLength(255)]
        public string Parent_Psys { get; set; }

        [StringLength(50)]
        public string PFDGuid { get; set; }

        [StringLength(255)]
        public string PFXName { get; set; }

        [StringLength(50)]
        public string PingFenMethod { get; set; }
    }
}
