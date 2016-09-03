namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_BiaoDuan
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

        [StringLength(50)]
        public string BiaoDuanNo { get; set; }

        [StringLength(500)]
        public string BiaoDuanName { get; set; }

        [StringLength(500)]
        public string JianSheDanWei { get; set; }

        [StringLength(500)]
        public string DaiLiName { get; set; }

        [StringLength(50)]
        public string IsAllowLHT { get; set; }

        [StringLength(50)]
        public string SoftCode { get; set; }

        [StringLength(50)]
        public string Version { get; set; }

        [StringLength(50)]
        public string IsXYXPS_TechEnd { get; set; }

        [StringLength(50)]
        public string IsFBTKPSEnd { get; set; }

        [StringLength(50)]
        public string JiemiMiute { get; set; }

        [StringLength(50)]
        public string IsBJHLXPFHZ { get; set; }

        [StringLength(50)]
        public string IsZiGeYSEnd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TuiJianPwFzrNo { get; set; }

        [StringLength(50)]
        public string IsBaoJiaHeLiXPFEnd { get; set; }

        [StringLength(50)]
        public string IsQiTaEnd { get; set; }

        [StringLength(50)]
        public string IsQiTaHZ { get; set; }

        public DateTime? PingBiaoDate { get; set; }

        [StringLength(50)]
        public string IsChuBuPSEnd { get; set; }

        [StringLength(50)]
        public string PingBiaoIsStart { get; set; }

        [StringLength(50)]
        public string IsZHBHZ { get; set; }

        [StringLength(1000)]
        public string ZhaoBiaoFW { get; set; }

        [StringLength(500)]
        public string GongZuoRY { get; set; }

        [StringLength(4000)]
        public string YiChangQK { get; set; }

        [StringLength(150)]
        public string PingBiaoAdress { get; set; }

        public int? IsZhengFuTouZi { get; set; }

        [StringLength(50)]
        public string ZBR_Guid { get; set; }

        [StringLength(500)]
        public string ZBR_UnitName { get; set; }

        [StringLength(50)]
        public string IsZongHeBiaoEnd { get; set; }

        [StringLength(50)]
        public string IsXSPSEnd { get; set; }

        [StringLength(50)]
        public string IsXYXPSEnd { get; set; }

        [StringLength(50)]
        public string IsTechEnd { get; set; }

        [StringLength(50)]
        public string YuDingGuid { get; set; }

        [StringLength(50)]
        public string IsValidCheckEnd { get; set; }

        public DateTime? allowJieMiData { get; set; }

        [StringLength(500)]
        public string KaiBiaoAddress { get; set; }

        [StringLength(50)]
        public string KaiBiaoTime { get; set; }

        [StringLength(500)]
        public string BeiZhu { get; set; }

        [StringLength(50)]
        public string JBR_Guid { get; set; }

        [StringLength(50)]
        public string JBR_Name { get; set; }

        public DateTime? KaiBiaoDate { get; set; }

        [StringLength(50)]
        public string PingBiaoIsEnd { get; set; }

        [StringLength(50)]
        public string ZhaoBiaoR { get; set; }

        public int? Jhgq { get; set; }

        [StringLength(50)]
        public string Zlyq { get; set; }

        public int? IsAllZhengFuTouzi { get; set; }

        public int? IsUseYCPingBiao { get; set; }

        [StringLength(50)]
        public string IsBiaoJiaBJB { get; set; }

        [StringLength(50)]
        public string IsTouBiaoJGFX { get; set; }

        [StringLength(50)]
        public string IsQingDanFX { get; set; }

        [StringLength(50)]
        public string IsCuoShiXMFX { get; set; }

        [StringLength(50)]
        public string IsEcoFX { get; set; }

        [StringLength(50)]
        public string IsQuFeiCheck { get; set; }

        [StringLength(50)]
        public string IsQingDanFHXJC { get; set; }

        [StringLength(50)]
        public string IsCuoShiFHXJC { get; set; }

        [StringLength(50)]
        public string IsQiTaFHXJC { get; set; }

        [StringLength(50)]
        public string IsCuoShiXMHXFX { get; set; }

        [StringLength(50)]
        public string IsDXGCFX { get; set; }

        [StringLength(50)]
        public string KaiBiaoR_Guid { get; set; }

        [StringLength(50)]
        public string KaiBiaoR_Name { get; set; }

        [StringLength(50)]
        public string JianGuanRYDL1 { get; set; }

        [StringLength(50)]
        public string JianGuanRYDL2 { get; set; }

        [StringLength(50)]
        public string IsMathErrCheck { get; set; }

        [StringLength(50)]
        public string IsEcoEnd { get; set; }

        [StringLength(50)]
        public string IsMathErrCheck_New { get; set; }

        [StringLength(1000)]
        public string GongChengXingZhi { get; set; }

        public DateTime? JunGongShiJian { get; set; }

        public DateTime? KaiGongShiJian { get; set; }

        [StringLength(50)]
        public string CengShu { get; set; }

        [StringLength(255)]
        public string JianSheGuiMo { get; set; }

        [StringLength(255)]
        public string JianZhuJieGou { get; set; }

        [StringLength(50)]
        public string HistoryDB_Name { get; set; }

        public int? If_Moved { get; set; }

        [StringLength(200)]
        public string Text1 { get; set; }

        [StringLength(200)]
        public string Text2 { get; set; }

        [Column(TypeName = "ntext")]
        public string Text3 { get; set; }

        [Column(TypeName = "ntext")]
        public string Text4 { get; set; }

        [StringLength(2)]
        public string IsNiDingQuestion { get; set; }

        [StringLength(50)]
        public string IsDoBiaoJiaoBJB { get; set; }

        [StringLength(3000)]
        public string ZBFileAttchGuid { get; set; }

        [StringLength(3000)]
        public string ZBFileAttachConnectionString { get; set; }

        [StringLength(1)]
        public string IsChangBiao { get; set; }

        public int? IsChongPing { get; set; }

        [StringLength(250)]
        public string PingBiaoBF { get; set; }

        [StringLength(250)]
        public string FanBenNo { get; set; }

        public DateTime? QingBiaoTime { get; set; }

        public int? QingBiaoDWNum { get; set; }

        [StringLength(50)]
        public string BDFileAttachGuid { get; set; }

        [StringLength(50)]
        public string BDFileAttachConnectionString { get; set; }

        public int? PingBiaoDWNum { get; set; }

        [StringLength(50)]
        public string DecrZB_UserGuid { get; set; }

        [StringLength(50)]
        public string DecrZB_Name { get; set; }

        public DateTime? DecrZB_date { get; set; }

        [StringLength(200)]
        public string DecrZB_UnitName { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string QingBiaoBGAttachGuid { get; set; }

        [StringLength(50)]
        public string PingBiaoBGAttachGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ControlPrice { get; set; }

        [StringLength(50)]
        public string DaiLiGuid { get; set; }

        [StringLength(1)]
        public string IsPause { get; set; }

        [StringLength(50)]
        public string IsNeedSecondEnvelope { get; set; }

        [StringLength(50)]
        public string domain { get; set; }

        [StringLength(50)]
        public string PingBiaoBGConnectionString { get; set; }

        [StringLength(50)]
        public string QingBiaoBGConnectionString { get; set; }

        public int? FeiBiaoRound { get; set; }

        [StringLength(50)]
        public string IsDlxmFHXJC { get; set; }

        [StringLength(50)]
        public string SysXiaQuCode { get; set; }

        [StringLength(50)]
        public string K1 { get; set; }

        [StringLength(50)]
        public string Q1 { get; set; }

        [StringLength(50)]
        public string ZbXmGuid { get; set; }

        [StringLength(100)]
        public string PingBiaoEndOperator { get; set; }

        [StringLength(50)]
        public string QingBiaoIsEnd { get; set; }

        [StringLength(250)]
        public string QingBiaoOperator { get; set; }

        public DateTime? KaiBiaoEndTime { get; set; }

        [StringLength(250)]
        public string KaiBiaoEndOperator { get; set; }

        [StringLength(50)]
        public string toubiaoXS { get; set; }

        [Column(TypeName = "ntext")]
        public string PBYiChangQK { get; set; }

        [StringLength(50)]
        public string KBAttachGuid { get; set; }

        [StringLength(50)]
        public string KBConnectionString { get; set; }

        public int? BaoJiaRound { get; set; }

        [StringLength(50)]
        public string XiaQuCode { get; set; }

        [StringLength(50)]
        public string IsKaiBiaoEnd { get; set; }

        [StringLength(1)]
        public string IsFromWeb { get; set; }

        [StringLength(200)]
        public string PingBiaoAddress { get; set; }

        [StringLength(50)]
        public string IsTongBu { get; set; }

        [StringLength(50)]
        public string ALLowFZRIsJiaFang { get; set; }

        [StringLength(50)]
        public string KBGZY_Guid { get; set; }

        [StringLength(50)]
        public string KBGZY_Name { get; set; }

        [StringLength(50)]
        public string QingDanBAAttachGuid { get; set; }

        [StringLength(50)]
        public string QingDanBAConnectionString { get; set; }

        [StringLength(50)]
        public string PackageStatus { get; set; }

        [Column(TypeName = "ntext")]
        public string B1 { get; set; }

        [Column(TypeName = "ntext")]
        public string B2 { get; set; }

        [StringLength(50)]
        public string IsZhongHeFX { get; set; }

        [StringLength(50)]
        public string EcoKBIsEnd { get; set; }

        [StringLength(50)]
        public string IsYouXXShenChaEnd { get; set; }

        [StringLength(50)]
        public string FuYiBiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string FuYiNum { get; set; }

        [StringLength(50)]
        public string ISFBPBDone { get; set; }

        [StringLength(50)]
        public string ZBFileStorageDate { get; set; }

        [StringLength(50)]
        public string DYFileStorageDate { get; set; }

        [StringLength(50)]
        public string BDFileStorageDate { get; set; }

        public DateTime? PingBiaoEndDate { get; set; }

        [StringLength(50)]
        public string IsOnReadingKBJL { get; set; }

        [StringLength(50)]
        public string IsOpenYingJi { get; set; }

        [StringLength(50)]
        public string IsKaiBiaoEnd_Ready { get; set; }

        [StringLength(50)]
        public string IsXunBiaoEnd { get; set; }

        public DateTime? XunBiaoEndDate { get; set; }

        [StringLength(50)]
        public string XunBiaoEndOperator { get; set; }

        [StringLength(50)]
        public string IsLiuBiao { get; set; }
    }
}
