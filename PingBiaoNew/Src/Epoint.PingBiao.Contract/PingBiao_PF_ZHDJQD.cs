namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PF_ZHDJQD : ModelBase
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
        public string BiaoDuanGuid { get; set; }

        public int? OrderNum { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string QingDanNO { get; set; }

        [StringLength(255)]
        public string QingDanName { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDiUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDi_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDi_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvgUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Avg_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Avg_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeastUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Least_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Least_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeastUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeast_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeast_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LaborUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MachineUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverheadUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Profit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RiskUnitPrice { get; set; }

        [StringLength(50)]
        public string ISQuery { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeTotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDiTotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvgTotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeastTotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeastTotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDiTotalPrice_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDiTotalPrice_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvgTotalPrice_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvgTotalPrice_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxTotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxTotalPrice_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeastTotalPrice_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeastTotalPrice_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeastTotalPrice_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeastTotalPrice_ChaE { get; set; }
    }
}
