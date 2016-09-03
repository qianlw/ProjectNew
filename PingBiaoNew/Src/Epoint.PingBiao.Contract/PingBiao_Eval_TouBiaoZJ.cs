namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PingBiao_Eval_TouBiaoZJ  ")]
    public partial class PingBiao_Eval_TouBiaoZJ : ModelBase
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

        [Column(TypeName = "numeric")]
        public decimal? Avg_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Avg_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LeastUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Least_ChaE { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string DanWeiName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDiUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDi_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Least_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeastUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeast_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CiLeast_ChaELv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDi_ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvgUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiaoTotal { get; set; }
    }
}
