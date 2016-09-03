namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_QuFeiCheck
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

        [StringLength(255)]
        public string FeiYongPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuFeiJS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FeiLv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiaoPriced { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GuiDingFl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CalPrice { get; set; }

        [StringLength(50)]
        public string IsOK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZhengPrice { get; set; }

        [StringLength(50)]
        public string ISTiaoZheng { get; set; }

        [StringLength(50)]
        public string FeiyongxLb { get; set; }

        [StringLength(50)]
        public string GuiFeiType { get; set; }

        [StringLength(255)]
        public string QuFeiName { get; set; }
    }
}
