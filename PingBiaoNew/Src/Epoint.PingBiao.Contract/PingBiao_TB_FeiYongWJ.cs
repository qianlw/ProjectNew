namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_FeiYongWJ : ModelBase
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

        [StringLength(255)]
        public string FeiYongName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuFeiJS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FeiLv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(255)]
        public string JsJc { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(50)]
        public string FeiYongXType { get; set; }

        [StringLength(250)]
        public string CostCode { get; set; }
    }
}
