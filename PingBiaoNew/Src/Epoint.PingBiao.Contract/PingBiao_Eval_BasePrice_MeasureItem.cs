namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_BasePrice_MeasureItem : ModelBase
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
        public string ordernum { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_Avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_BiaoDi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_CiLeast { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_Least { get; set; }

        [StringLength(50)]
        public string type { get; set; }
    }
}
