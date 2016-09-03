namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PFD : ModelBase
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
        public string PFDGuid { get; set; }

        [StringLength(50)]
        public string Tech_ShowNo { get; set; }

        [StringLength(3000)]
        public string PFDName { get; set; }

        [Column(TypeName = "ntext")]
        public string PFDRemark { get; set; }

        [StringLength(250)]
        public string PFDDangCi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? D1Min { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? D1Max { get; set; }

        [StringLength(50)]
        public string Tech_IsParents { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tech_QuanZhong { get; set; }

        [StringLength(50)]
        public string BaoJiaKouFenFormula { get; set; }

        [StringLength(50)]
        public string BaoJiaBaseFormula { get; set; }

        [Column(TypeName = "ntext")]
        public string ZongHeUnitPrice_Params { get; set; }

        [StringLength(50)]
        public string Tech_PingFenMethod { get; set; }

        [StringLength(50)]
        public string IsAllowNegative { get; set; }

        public int? PFDType { get; set; }

        [StringLength(50)]
        public string UserType { get; set; }

        [StringLength(50)]
        public string HuiZongType { get; set; }

        [StringLength(50)]
        public string IsSheZhi { get; set; }

        [StringLength(255)]
        public string ZiGeBiaoZhun { get; set; }

        [StringLength(255)]
        public string YouXiaoZM { get; set; }

        public int? ZhPWS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZF { get; set; }

        [StringLength(1000)]
        public string Psbz { get; set; }

        [StringLength(255)]
        public string Parent_Psys { get; set; }

        [StringLength(50)]
        public string MixType { get; set; }

        public int? BidId { get; set; }

        [StringLength(50)]
        public string TreeNodeID { get; set; }

        public int? IsZJF { get; set; }

        public int? AutoCalc { get; set; }

        [StringLength(50)]
        public string PingFenMethod { get; set; }

        public int? IsMustPass { get; set; }

        [StringLength(50)]
        public string MustMark { get; set; }

        [StringLength(500)]
        public string PFDMapUrl { get; set; }

        [StringLength(500)]
        public string BidFormulaParams { get; set; }

        [StringLength(500)]
        public string FormulaKouFenParams { get; set; }

        [StringLength(50)]
        public string XH { get; set; }

        public int? PWS { get; set; }

        [StringLength(200)]
        public string BidFormula { get; set; }

        [StringLength(200)]
        public string FormulaKouFen { get; set; }

        [StringLength(50)]
        public string EconomicPWS { get; set; }

        [StringLength(300)]
        public string ZongHeUnitPriceFormula { get; set; }

        [StringLength(500)]
        public string ZhiGeFormula { get; set; }

        [StringLength(500)]
        public string ZhiGeFormulaParam { get; set; }

        [StringLength(50)]
        public string ZGSCType { get; set; }

        [StringLength(50)]
        public string PFDMapDesp { get; set; }

        [StringLength(50)]
        public string PFDMapType { get; set; }
    }
}
