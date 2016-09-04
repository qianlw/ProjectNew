namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_RcjhzMx : ModelBase
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(50)]
        public string DanWeiGCName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Ysj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Dj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Hj { get; set; }

        [StringLength(50)]
        public string RcjId { get; set; }

        [StringLength(50)]
        public string RcjBm { get; set; }

        [StringLength(50)]
        public string Mc { get; set; }

        [StringLength(50)]
        public string Ggxh { get; set; }

        [StringLength(50)]
        public string Dw { get; set; }

        [StringLength(50)]
        public string Zbjxbz { get; set; }

        [StringLength(50)]
        public string Jgbz { get; set; }

        [StringLength(50)]
        public string Sbbz { get; set; }

        [StringLength(50)]
        public string Wjjclbz { get; set; }

        [StringLength(50)]
        public string Cd { get; set; }

        [StringLength(50)]
        public string Gycs { get; set; }

        [StringLength(50)]
        public string Bz { get; set; }

        [StringLength(50)]
        public string Rcjlb { get; set; }

        [StringLength(50)]
        public string Pblb { get; set; }
    }
}
