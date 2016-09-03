namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_Csxm1Mx
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        [Key]
        [Column(Order = 0)]
        public int Row_ID { get; set; }

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(255)]
        public string Jsjc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Je { get; set; }

        [StringLength(50)]
        public string Xmlb { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string Xh { get; set; }

        [StringLength(255)]
        public string Mc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Js { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(2)]
        public string ISBiaoDi { get; set; }

        [StringLength(2)]
        public string ISMathErrCheckTZ { get; set; }

        [StringLength(2)]
        public string DuoQueX { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }

        [StringLength(2000)]
        public string Mc_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Je_OK { get; set; }

        [StringLength(2)]
        public string ISValidCheckTZ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fl_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? js_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Jjrg { get; set; }
    }
}
