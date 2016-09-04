namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_QingDanItem : ModelBase
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

        [StringLength(40)]
        public string QingDanNO { get; set; }

        [StringLength(800)]
        public string QingDanName { get; set; }

        public int? QingDanType { get; set; }

        [Column(TypeName = "ntext")]
        public string XiangMuTZ { get; set; }

        [StringLength(80)]
        public string Unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LaborUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MachineUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverheadUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Profit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RiskUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeTotalPrice { get; set; }

        [Column(TypeName = "ntext")]
        public string Remark { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(20)]
        public string Xh { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zgj { get; set; }

        [Column(TypeName = "ntext")]
        public string Gcnr { get; set; }

        [Column(TypeName = "ntext")]
        public string Jsgz { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zcf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fcf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zgr { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }

        [StringLength(100)]
        public string Unit_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeTotalPrice_OK { get; set; }

        public int? DuoQueX { get; set; }

        public int? IS_Accord_TZ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPrice_OK { get; set; }

        public int? Is_Error_TZ { get; set; }

        public int? ISBiaoDi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EquipmentRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RestRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LawfeeRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TaxRate { get; set; }

        [StringLength(255)]
        public string MainBQItem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LimitedRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zgj_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LaborUnitPrice_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialUnitPrice_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MachineUnitPrice_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverheadUnitPrice_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Profit_OK { get; set; }

        [Column(TypeName = "ntext")]
        public string TiaoZhengContent { get; set; }

        [StringLength(50)]
        public string ISQuery { get; set; }

        [Column(TypeName = "ntext")]
        public string QingDanName_OK { get; set; }

        [Column(TypeName = "ntext")]
        public string XiangMuTZ_OK { get; set; }

        [StringLength(50)]
        public string BaoJiaHLXMark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Jjrg { get; set; }

        [StringLength(50)]
        public string DanXiangNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DergfDj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DergfHj { get; set; }

        [StringLength(2)]
        public string IsQDFX { get; set; }

        [StringLength(1)]
        public string IsZongHeUnitPriceFX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuanZhong { get; set; }

        [StringLength(255)]
        public string Xmbm { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zjfqt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zjfqtfl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Jjffl { get; set; }

        [StringLength(50)]
        public string Js { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Qtgcf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Jjf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sj { get; set; }

        [StringLength(50)]
        public string Iszg { get; set; }

        [StringLength(50)]
        public string Djfx { get; set; }

        [StringLength(250)]
        public string Parent_Qdbm { get; set; }
    }
}
