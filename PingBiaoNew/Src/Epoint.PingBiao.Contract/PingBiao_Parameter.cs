namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Parameter : ModelBase
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
        public string YuShenIsNeed { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalScore_Eco { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalScore_Tech { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalScore_Zonghe { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalScore_GongQi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalScore_Quality { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalScore_Other { get; set; }

        [StringLength(50)]
        public string Tech_PingFenMethod { get; set; }

        [StringLength(50)]
        public string Tech_IsAnBiao { get; set; }

        public int? Tech_TotalPage { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tech_OverPageKouNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tech_PassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tech_LastPassPoint { get; set; }

        [StringLength(50)]
        public string Tech_AllowModifyCatalog { get; set; }

        public int? Tech_OverNum { get; set; }

        public int? Tech_RemoveMin { get; set; }

        [StringLength(50)]
        public string Tech_RemoveMaxMinGetAvg { get; set; }

        public int? Tech_RemoveMax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? XianJia { get; set; }

        public int? IsZhengFuTouZi { get; set; }

        public int? IsAllZhengFuTouzi { get; set; }

        public int? IsUseYCPingBiao { get; set; }

        public int? Econ_CuoShi_OverNum { get; set; }

        public int? Econ_CuoShi_RemoveMax { get; set; }

        public int? Econ_CuoShi_RemoveMin { get; set; }

        public int? ZhPWS { get; set; }

        public int? EconomicPWS { get; set; }

        [StringLength(50)]
        public string OtherTotal1 { get; set; }

        [StringLength(50)]
        public string OtherTotal2 { get; set; }

        [StringLength(50)]
        public string OtherTotal3 { get; set; }

        [StringLength(50)]
        public string OtherTotal4 { get; set; }

        [StringLength(50)]
        public string OtherTotal5 { get; set; }

        [StringLength(50)]
        public string OtherTotal6 { get; set; }

        [StringLength(50)]
        public string OtherTotal7 { get; set; }

        [StringLength(50)]
        public string OtherTotal0 { get; set; }

        [StringLength(50)]
        public string XiangMuType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BZJMoney { get; set; }

        public DateTime? KaiBiaoDate { get; set; }

        [StringLength(50)]
        public string ShiGongHZ { get; set; }

        public int? TouBiaoYouXiao { get; set; }

        public int? IsWeiTuo { get; set; }

        public int? Econ_QingDan_OverNum { get; set; }

        public int? Econ_QingDan_RemoveMax { get; set; }

        public int? Econ_QingDan_RemoveMin { get; set; }

        public int? IsNeed { get; set; }

        public int? PageMax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PageKF { get; set; }

        public int? IsNeedML { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Eco_Heavyweights { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tech_Heavyweights { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZhongHe_Heavyweights { get; set; }

        [StringLength(50)]
        public string TechIsNeed { get; set; }

        [StringLength(50)]
        public string ZhongHeIsNeed { get; set; }

        [StringLength(50)]
        public string PingBiaoType { get; set; }

        [StringLength(50)]
        public string ZongHePFMethod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NoDlxmJzzRlv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Rate { get; set; }

        [StringLength(50)]
        public string PingBiaoBF { get; set; }

        [StringLength(50)]
        public string K1 { get; set; }

        [StringLength(50)]
        public string Q1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DlxmJZZ { get; set; }

        [StringLength(1)]
        public string IsNeedSecondEnvelope { get; set; }

        [StringLength(50)]
        public string IsDaFenPanDingPass { get; set; }

        [StringLength(50)]
        public string ZhDFType { get; set; }

        [StringLength(50)]
        public string EconomicDFType { get; set; }

        [StringLength(50)]
        public string TechDFType { get; set; }

        [StringLength(50)]
        public string PBJCalcType { get; set; }

        [StringLength(50)]
        public string TBRCalcJZZType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zlje { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zgj { get; set; }

        [StringLength(50)]
        public string QTDFType { get; set; }

        [StringLength(50)]
        public string TechPWS { get; set; }

        [StringLength(50)]
        public string Econ_PingFenMethod { get; set; }

        [StringLength(50)]
        public string QT_PingFenMethod { get; set; }

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
        public string QTPWS { get; set; }

        public int? ChuBuPWS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Eco_PassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Eco_LastPassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zh_PassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zh_LastPassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QT_LastPassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QT_PassPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QiTa_Heavyweights { get; set; }
    }
}
