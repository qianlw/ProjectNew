namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_LastMark : ModelBase
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
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        public int? OrderNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EconMark { get; set; }

        [StringLength(50)]
        public string TechPass { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TechMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GongQiMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QualityMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OtherMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaoJiaTotalMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QingDanTotalMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MeasureTotalMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPriceMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? B1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? B2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? B3 { get; set; }

        public int? PaiMing { get; set; }

        [StringLength(50)]
        public string ISZhongBiao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaoJiaHLXMark { get; set; }

        [StringLength(50)]
        public string B4 { get; set; }

        [StringLength(50)]
        public string B5 { get; set; }

        [StringLength(50)]
        public string B6 { get; set; }

        [StringLength(50)]
        public string B7 { get; set; }

        [StringLength(50)]
        public string B8 { get; set; }

        [StringLength(50)]
        public string B9 { get; set; }

        [StringLength(50)]
        public string B10 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Last_TotalPrice { get; set; }

        [StringLength(50)]
        public string QingDanNO { get; set; }

        [StringLength(50)]
        public string DanWeiGCName { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(50)]
        public string Parent_No { get; set; }

        [StringLength(1)]
        public string EconPass { get; set; }

        [StringLength(50)]
        public string OtherPass { get; set; }

        [StringLength(50)]
        public string ZongHePass { get; set; }

        [StringLength(50)]
        public string IsZiGeYSPass { get; set; }

        [StringLength(50)]
        public string IsXSPSPass { get; set; }

        [StringLength(50)]
        public string IsYouXiaoXingPass { get; set; }

        [StringLength(50)]
        public string IsBaoJiaHeLiXPFPass { get; set; }

        [StringLength(50)]
        public string IsChuBuPass { get; set; }

        [StringLength(50)]
        public string IsTechPass { get; set; }

        [StringLength(50)]
        public string IsXYXPSPass { get; set; }
    }
}
