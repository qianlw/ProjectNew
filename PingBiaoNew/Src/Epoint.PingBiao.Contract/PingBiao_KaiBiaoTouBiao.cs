namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_KaiBiaoTouBiao : ModelBase
    {
        [StringLength(50)]
        public string FileMiFeng { get; set; }

        [StringLength(50)]
        public string GongQi { get; set; }

        [StringLength(50)]
        public string BaoZhengJin { get; set; }

        [StringLength(50)]
        public string TouBiaoTotal { get; set; }

        [StringLength(50)]
        public string FaRenDb { get; set; }

        [StringLength(50)]
        public string XiangMuJL { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [StringLength(255)]
        public string Zlcn { get; set; }

        [StringLength(50)]
        public string QianShou { get; set; }

        [StringLength(50)]
        public string ZhengShuYX { get; set; }

        [StringLength(50)]
        public string IsSucceed { get; set; }

        [StringLength(50)]
        public string UseToolName { get; set; }

        [StringLength(50)]
        public string IsChuBuPS { get; set; }

        [StringLength(50)]
        public string ZiShengPmName { get; set; }

        [StringLength(50)]
        public string CBS_Code { get; set; }

        [StringLength(50)]
        public string CBS_Name { get; set; }

        [StringLength(50)]
        public string CBS_Date { get; set; }

        [StringLength(50)]
        public string IsNextPass { get; set; }

        [StringLength(1)]
        public string IsFeiBiao { get; set; }

        [Column(TypeName = "ntext")]
        public string FeiBiaoReason { get; set; }

        [StringLength(50)]
        public string AnBiaoNo { get; set; }

        public int? AllPages { get; set; }

        [StringLength(500)]
        public string PagesDetail { get; set; }

        [StringLength(255)]
        public string FeiBiaoJD { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        public DateTime? ComeTime { get; set; }

        public DateTime? LeaveTime { get; set; }

        [StringLength(1)]
        public string IsAnShi { get; set; }

        [StringLength(50)]
        public string UseToolVersion { get; set; }

        [StringLength(50)]
        public string ZaoJiaRBH { get; set; }

        [StringLength(50)]
        public string ZaoJiaRXM { get; set; }

        [StringLength(50)]
        public string Dblx { get; set; }

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
        public string ClientGuid { get; set; }

        [StringLength(50)]
        public string IsJieMi { get; set; }

        [StringLength(50)]
        public string ToolSoftName { get; set; }

        [StringLength(500)]
        public string TBMacAddress { get; set; }

        public DateTime? UPR_DATE { get; set; }

        [StringLength(50)]
        public string TBIP { get; set; }

        public DateTime? TBCreateDate { get; set; }

        [StringLength(500)]
        public string TBMakeMacAddress { get; set; }

        [StringLength(50)]
        public string TBFileGuid { get; set; }

        [StringLength(50)]
        public string TBFileName { get; set; }

        [StringLength(50)]
        public string IsChuBuPass { get; set; }

        [StringLength(50)]
        public string TBFileAttchGuid { get; set; }

        [StringLength(200)]
        public string TBFileAttachConnectionString { get; set; }

        public int? TBImportPercent { get; set; }

        [Column(TypeName = "ntext")]
        public string DigitalEnvelope { get; set; }

        [StringLength(1)]
        public string IsPayForBzj { get; set; }

        public DateTime? JiaoNaDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BzjMoney { get; set; }

        [Column(TypeName = "ntext")]
        public string DecrTB { get; set; }

        [StringLength(500)]
        public string DecrTB_UnitName { get; set; }

        public DateTime? DecrTBJieMi_Date { get; set; }

        [StringLength(50)]
        public string DecrZB_Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ChengXinFeng { get; set; }

        [StringLength(1)]
        public string IsNeedSecondCheck { get; set; }

        [Column(TypeName = "ntext")]
        public string DecrSK { get; set; }

        public DateTime? DecrZB_Date { get; set; }

        [StringLength(50)]
        public string DecrZB_UserGuid { get; set; }

        [StringLength(50)]
        public string IsYouXiaoXingPass { get; set; }

        [StringLength(50)]
        public string IsTechSucceed { get; set; }

        [StringLength(255)]
        public string SuoNumber { get; set; }

        [StringLength(255)]
        public string JiaoYanNumber { get; set; }

        public DateTime? EndBiaoShuDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TbrRlv { get; set; }

        [StringLength(50)]
        public string IsPFFinish { get; set; }

        [StringLength(10)]
        public string IsTouBiao { get; set; }

        [StringLength(50)]
        public string ZZJGDM { get; set; }

        [StringLength(50)]
        public string QYDF { get; set; }

        [StringLength(50)]
        public string XMJL { get; set; }

        [StringLength(50)]
        public string XMJLDF { get; set; }

        [StringLength(50)]
        public string Biaoduanno { get; set; }

        [StringLength(50)]
        public string gongqiWB { get; set; }

        [StringLength(1)]
        public string IsTechPass { get; set; }

        [StringLength(1)]
        public string IsXYXPSPass { get; set; }

        [StringLength(1)]
        public string IsZiGeYSPass { get; set; }

        [StringLength(1)]
        public string IsXSPSPass { get; set; }

        [StringLength(1)]
        public string IsBaoJiaHeLiXPFPass { get; set; }

        [StringLength(50)]
        public string IsDlbjYouXiao { get; set; }

        [Column(TypeName = "ntext")]
        public string DlxmbjWuXiaoReason { get; set; }

        public DateTime? TuiHuiTime { get; set; }

        [StringLength(255)]
        public string TuiHuiReason { get; set; }

        [StringLength(50)]
        public string LianXiRen { get; set; }

        [StringLength(50)]
        public string LiXiRenTel { get; set; }

        [StringLength(50)]
        public string LiXiMobile { get; set; }

        [StringLength(50)]
        public string IsCalculated { get; set; }

        [Column(TypeName = "ntext")]
        public string TBFileDigitalSignal { get; set; }

        [Column(TypeName = "ntext")]
        public string ZBREncryptPublicKey { get; set; }

        [Column(TypeName = "ntext")]
        public string TBREncryptPublicKey { get; set; }

        [Column(TypeName = "ntext")]
        public string TBRPublicKey { get; set; }

        [StringLength(50)]
        public string FileGLGuid { get; set; }

        [Column(TypeName = "ntext")]
        public string ZiShenZiLiao { get; set; }

        [StringLength(200)]
        public string B1 { get; set; }

        [StringLength(200)]
        public string B2 { get; set; }

        [StringLength(50)]
        public string B3 { get; set; }

        [StringLength(50)]
        public string ISCanYuPb { get; set; }

        [StringLength(500)]
        public string KaiBiaoReMark { get; set; }

        [StringLength(50)]
        public string IsUseDisk { get; set; }

        [StringLength(50)]
        public string BZJType { get; set; }

        [StringLength(50)]
        public string CreateGuid { get; set; }

        [StringLength(500)]
        public string ZiGeYSReason { get; set; }

        [StringLength(500)]
        public string YouXXShenChaReason { get; set; }

        [StringLength(500)]
        public string TechKBRemark { get; set; }

        [Column(TypeName = "ntext")]
        public string DecrZX { get; set; }

        [StringLength(50)]
        public string DecrZX_Name { get; set; }

        [StringLength(50)]
        public string DecrZX_UserGuid { get; set; }

        public DateTime? DecrZX_Date { get; set; }

        [StringLength(50)]
        public string DecrTB_ZT { get; set; }

        [StringLength(50)]
        public string DecrSK_ZT { get; set; }

        [StringLength(50)]
        public string IsTechSucceedShow { get; set; }

        [StringLength(50)]
        public string TBFileStorageData { get; set; }

        [StringLength(500)]
        public string ZBRRemark { get; set; }

        [StringLength(50)]
        public string XunBiao_Status { get; set; }

        [StringLength(50)]
        public string IsEcoSucceed { get; set; }
    }
}
