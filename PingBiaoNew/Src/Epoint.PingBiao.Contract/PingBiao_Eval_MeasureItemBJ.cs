namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_MeasureItemBJ : ModelBase
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

        [StringLength(50)]
        public string OrderNum { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(255)]
        public string MeasuerItemName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiaoTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HanLiang { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvgTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Avg_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Avg_ChaELV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeastTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Least_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Least_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeastTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiDiLeast_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiDiLeast_ChaELV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDiTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDi_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDi_ChaELv { get; set; }

        [StringLength(50)]
        public string IsHeLi { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MeasueTotal { get; set; }
    }
}
