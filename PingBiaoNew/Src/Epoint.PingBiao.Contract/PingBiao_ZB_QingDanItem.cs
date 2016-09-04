namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_QingDanItem : ModelBase
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

        [StringLength(20)]
        public string QingDanNO { get; set; }

        [StringLength(800)]
        public string QingDanName { get; set; }

        [Column(TypeName = "ntext")]
        public string XiangMuTZ { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongheUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongheTotalPrice { get; set; }

        [Column(TypeName = "ntext")]
        public string Remark { get; set; }

        [StringLength(50)]
        public string QingDanType { get; set; }

        [StringLength(255)]
        public string DANWEIGCNO { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }

        [StringLength(250)]
        public string MainBQItem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LimitedRate { get; set; }

        [StringLength(50)]
        public string DanXiangNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? zgj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DergfDj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DergfHj { get; set; }

        [StringLength(1)]
        public string IsZongHeUnitPriceFX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuanZhong { get; set; }

        [StringLength(255)]
        public string Xmbm { get; set; }

        [StringLength(50)]
        public string Js { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity2 { get; set; }

        [StringLength(50)]
        public string Iszg { get; set; }

        [StringLength(50)]
        public string Djfx { get; set; }

        [StringLength(500)]
        public string Parent_Qdbm { get; set; }

        public string Gcnr { get; set; }
    }
}
