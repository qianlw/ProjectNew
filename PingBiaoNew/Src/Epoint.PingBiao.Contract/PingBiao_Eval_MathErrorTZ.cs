namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_MathErrorTZ
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
        public string OrderNum { get; set; }

        [StringLength(255)]
        public string TiaoZhengContent { get; set; }

        [StringLength(50)]
        public string UNIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CalTotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZhengPrice { get; set; }

        [StringLength(50)]
        public string LineType { get; set; }
    }
}
