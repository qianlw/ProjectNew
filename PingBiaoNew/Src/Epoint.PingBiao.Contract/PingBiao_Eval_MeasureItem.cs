namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_MeasureItem : ModelBase
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

        [Column(TypeName = "numeric")]
        public decimal? BiaoDi_ChaELv { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(50)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvgUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Avg_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeastUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Least_ChaE { get; set; }

        [StringLength(3000)]
        public string MeasureItemName { get; set; }

        [StringLength(50)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string MeasureItemType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? JE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDiUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDi_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Least_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeastUnitPrice { get; set; }

        public int? OrderNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeast_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeast_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Avg_ChaELv { get; set; }
    }
}
