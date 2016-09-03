namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_MeasureItem : ModelBase
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
        public string MeasureItemId { get; set; }

        [StringLength(50)]
        public string OrderNum { get; set; }

        [StringLength(50)]
        public string MeasureItemType { get; set; }

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

        [StringLength(255)]
        public string DANWEIGCNO { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuFeiJS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FeiLv { get; set; }

        [Column(TypeName = "ntext")]
        public string Gcnr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zcf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fcf { get; set; }

        [Column(TypeName = "ntext")]
        public string Jsgz { get; set; }

        [Column(TypeName = "ntext")]
        public string MeasureItemName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zgj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zgr { get; set; }

        [Column(TypeName = "ntext")]
        public string Xmtz { get; set; }

        [StringLength(2)]
        public string ISBiaoDi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPrice_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeTotalPrice_OK { get; set; }

        [StringLength(2)]
        public string ISValidCheckTZ { get; set; }

        [StringLength(2)]
        public string ISMathErrCheckTZ { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }

        [StringLength(2)]
        public string DuoQueX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zgj_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity_OK { get; set; }

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

        [Column(TypeName = "ntext")]
        public string MeasureItemName_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Jjrg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DergfDj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DergfHj { get; set; }
    }
}
