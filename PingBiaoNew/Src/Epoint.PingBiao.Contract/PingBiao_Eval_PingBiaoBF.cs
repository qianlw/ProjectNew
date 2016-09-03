namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_PingBiaoBF : ModelBase
    {
        [StringLength(50)]
        public string IsSel { get; set; }

        public int? BidId { get; set; }

        [StringLength(50)]
        public string BidName { get; set; }

        [StringLength(50)]
        public string TechIsNeed { get; set; }

        [StringLength(50)]
        public string Selected { get; set; }

        [StringLength(50)]
        public string ZongHeIsNeed { get; set; }

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
        public string P11IsNeed { get; set; }

        [StringLength(50)]
        public string P15IsNeed { get; set; }

        [StringLength(50)]
        public string P9IsNeed { get; set; }

        [StringLength(50)]
        public string P20IsNeed { get; set; }

        [StringLength(50)]
        public string P4IsNeed { get; set; }

        [StringLength(50)]
        public string P5IsNeed { get; set; }

        [StringLength(50)]
        public string P6IsNeed { get; set; }

        [StringLength(50)]
        public string P7IsNeed { get; set; }

        [StringLength(50)]
        public string P8IsNeed { get; set; }

        [StringLength(100)]
        public string Mark { get; set; }

        [StringLength(50)]
        public string XiaQuCode { get; set; }

        [StringLength(50)]
        public string domain { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        [StringLength(50)]
        public string P12IsNeed { get; set; }

        [StringLength(50)]
        public string P13IsNeed { get; set; }

        [StringLength(10)]
        public string IsNeedQuanZhong { get; set; }

        [StringLength(3000)]
        public string TypeReName { get; set; }

        [StringLength(10)]
        public string IsNeedSecondEnvelope { get; set; }

        [StringLength(50)]
        public string Areas { get; set; }

        [StringLength(100)]
        public string TechValueType { get; set; }

        [StringLength(50)]
        public string EnableAnBiao { get; set; }

        [StringLength(500)]
        public string CouQuInfo { get; set; }

        [StringLength(50)]
        public string P1IsNeed { get; set; }

        [StringLength(50)]
        public string GuiFeiIsNeed { get; set; }

        [StringLength(50)]
        public string PBJCalcType { get; set; }

        [StringLength(50)]
        public string EconomicDFType { get; set; }

        [StringLength(50)]
        public string TechDFType { get; set; }

        [StringLength(50)]
        public string ZhDFType { get; set; }

        [StringLength(50)]
        public string QTDFType { get; set; }

        [StringLength(50)]
        public string TBRCalcJZZType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tech_PassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tech_LastPassPoint { get; set; }

        [StringLength(50)]
        public string TechSelectType { get; set; }

        [StringLength(50)]
        public string EcoSelectType { get; set; }

        [StringLength(50)]
        public string ZhSelectType { get; set; }

        [StringLength(50)]
        public string QTSelectType { get; set; }

        [StringLength(100)]
        public string JZZSelectType { get; set; }

        [StringLength(100)]
        public string KFSelectType { get; set; }

        [StringLength(100)]
        public string QDSelectType { get; set; }

        [StringLength(100)]
        public string ZXSelectType { get; set; }

        public int? OrderNum { get; set; }

        [StringLength(50)]
        public string IsCheckQDName { get; set; }

        [StringLength(50)]
        public string IsCheckQDTZ { get; set; }

        [StringLength(50)]
        public string TechIsQDFBDanWei { get; set; }

        [StringLength(50)]
        public string IsCheckQDDJError { get; set; }

        [StringLength(50)]
        public string JSErrorJCWCSet { get; set; }

        [StringLength(50)]
        public string CheckFW { get; set; }

        [StringLength(50)]
        public string TechHz { get; set; }

        [StringLength(50)]
        public string ZgscType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZgscPassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TechPassPoint { get; set; }

        [StringLength(50)]
        public string TechPFMethod { get; set; }

        [StringLength(50)]
        public string ZongHePFMethod { get; set; }

        [StringLength(50)]
        public string EcoPFMethod { get; set; }

        [StringLength(50)]
        public string QTPFMethod { get; set; }

        [StringLength(50)]
        public string P15DaFenType { get; set; }

        [StringLength(50)]
        public string P4DaFenType { get; set; }

        [StringLength(50)]
        public string P5DaFenType { get; set; }

        [StringLength(50)]
        public string P6DaFenType { get; set; }

        [StringLength(50)]
        public string P7DaFenType { get; set; }

        [StringLength(50)]
        public string P8DaFenType { get; set; }

        [StringLength(50)]
        public string PFDMapType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Eco_PassPoint { get; set; }

        public int? ZgscPassPpoint { get; set; }

        [StringLength(50)]
        public string QTPWS { get; set; }

        [StringLength(50)]
        public string ZHPWS { get; set; }

        [StringLength(50)]
        public string TechPWS { get; set; }

        [StringLength(50)]
        public string EconPWS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QT_LastPassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QT_PassPoint { get; set; }

        public int? Zh_LastPassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zh_PassPoint { get; set; }

        public int? Eco_LastPassPoint { get; set; }

        [StringLength(50)]
        public string ChuBuPWS { get; set; }

        public int? JieMiNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ChuBu_PassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ChuBu_LastPassPoint { get; set; }
    }
}
