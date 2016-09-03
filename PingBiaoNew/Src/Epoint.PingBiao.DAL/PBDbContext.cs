namespace Epoint.PingBiao.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Epoint.Framework.DAL;
    using Epoint.Core.Config;
    using Epoint.Core.Log;
    using Epoint.PingBiao.Contract;

    public partial class PBDbContext : DbContextBase
    {
        public PBDbContext()
            : base("PB", new LogDbContext())
        {
        }

        public virtual DbSet<PingBiao_BiaoDuan> PingBiao_BiaoDuan { get; set; }
        public virtual DbSet<PingBiao_ReportPara> PingBiao_ReportPara { get; set; }
        public virtual DbSet<JSGC_PB_EcoFile> JSGC_PB_EcoFile { get; set; }
        public virtual DbSet<PingBiao_Answer> PingBiao_Answer { get; set; }
        public virtual DbSet<PingBiao_Attach_Lock> PingBiao_Attach_Lock { get; set; }
        public virtual DbSet<PingBiao_BaoJiaHistroy> PingBiao_BaoJiaHistroy { get; set; }
        public virtual DbSet<PingBiao_BiaoDuanExt> PingBiao_BiaoDuanExt { get; set; }
        public virtual DbSet<PingBiao_BiaoJue> PingBiao_BiaoJue { get; set; }
        public virtual DbSet<PingBiao_BiaoJueDetail> PingBiao_BiaoJueDetail { get; set; }
        public virtual DbSet<PingBiao_BiaoShu_Marktime> PingBiao_BiaoShu_Marktime { get; set; }
        public virtual DbSet<PingBiao_BigMenu> PingBiao_BigMenu { get; set; }
        public virtual DbSet<PingBiao_BuZhouBack> PingBiao_BuZhouBack { get; set; }
        public virtual DbSet<PingBiao_BuZhouInfo> PingBiao_BuZhouInfo { get; set; }
        public virtual DbSet<PingBiao_BuZhouList> PingBiao_BuZhouList { get; set; }
        public virtual DbSet<PingBiao_ChenBenJiaPSCS> PingBiao_ChenBenJiaPSCS { get; set; }
        public virtual DbSet<PingBiao_CouQu> PingBiao_CouQu { get; set; }
        public virtual DbSet<PingBiao_DanWeiSign> PingBiao_DanWeiSign { get; set; }
        public virtual DbSet<PingBiao_DS_PDF> PingBiao_DS_PDF { get; set; }
        public virtual DbSet<PingBiao_DS_PDF_History> PingBiao_DS_PDF_History { get; set; }
        public virtual DbSet<PingBiao_Error> PingBiao_Error { get; set; }
        public virtual DbSet<PingBiao_Evak_PbDetail> PingBiao_Evak_PbDetail { get; set; }
        public virtual DbSet<PingBiao_Eval_BaojiaMark> PingBiao_Eval_BaojiaMark { get; set; }
        public virtual DbSet<PingBiao_Eval_BasePrice> PingBiao_Eval_BasePrice { get; set; }
        public virtual DbSet<PingBiao_Eval_BasePrice_MeasureItem> PingBiao_Eval_BasePrice_MeasureItem { get; set; }
        public virtual DbSet<PingBiao_Eval_BiaoJiaBJB> PingBiao_Eval_BiaoJiaBJB { get; set; }
        public virtual DbSet<PingBiao_Eval_CSFX> PingBiao_Eval_CSFX { get; set; }
        public virtual DbSet<PingBiao_Eval_DiYuCBJPD> PingBiao_Eval_DiYuCBJPD { get; set; }
        public virtual DbSet<PingBiao_Eval_DiYuCBJPS> PingBiao_Eval_DiYuCBJPS { get; set; }
        public virtual DbSet<PingBiao_Eval_DlxmAccordCheck> PingBiao_Eval_DlxmAccordCheck { get; set; }
        public virtual DbSet<PingBiao_Eval_DXGCFX> PingBiao_Eval_DXGCFX { get; set; }
        public virtual DbSet<PingBiao_Eval_FormulaBase> PingBiao_Eval_FormulaBase { get; set; }
        public virtual DbSet<PingBiao_Eval_FormulaDefined> PingBiao_Eval_FormulaDefined { get; set; }
        public virtual DbSet<PingBiao_Eval_FormulaList> PingBiao_Eval_FormulaList { get; set; }
        public virtual DbSet<PingBiao_Eval_FywjMxMathErrorTZ> PingBiao_Eval_FywjMxMathErrorTZ { get; set; }
        public virtual DbSet<PingBiao_Eval_GuifeiDefault> PingBiao_Eval_GuifeiDefault { get; set; }
        public virtual DbSet<PingBiao_Eval_GuifeiList> PingBiao_Eval_GuifeiList { get; set; }
        public virtual DbSet<PingBiao_Eval_GuifeiProjectSet> PingBiao_Eval_GuifeiProjectSet { get; set; }
        public virtual DbSet<PingBiao_Eval_LastMark> PingBiao_Eval_LastMark { get; set; }
        public virtual DbSet<PingBiao_Eval_MathErrors> PingBiao_Eval_MathErrors { get; set; }
        public virtual DbSet<PingBiao_Eval_MathErrorTZ> PingBiao_Eval_MathErrorTZ { get; set; }
        public virtual DbSet<PingBiao_Eval_MeasureAccordCheck> PingBiao_Eval_MeasureAccordCheck { get; set; }
        public virtual DbSet<PingBiao_Eval_MeasureItem> PingBiao_Eval_MeasureItem { get; set; }
        public virtual DbSet<PingBiao_Eval_MeasureItemBJ> PingBiao_Eval_MeasureItemBJ { get; set; }
        public virtual DbSet<PingBiao_Eval_OtherAccordCheck> PingBiao_Eval_OtherAccordCheck { get; set; }
        public virtual DbSet<PingBiao_Eval_PingBiaoBF> PingBiao_Eval_PingBiaoBF { get; set; }
        public virtual DbSet<PingBiao_Eval_QDDFDetail> PingBiao_Eval_QDDFDetail { get; set; }
        public virtual DbSet<PingBiao_Eval_QingDanAccordCheck> PingBiao_Eval_QingDanAccordCheck { get; set; }
        public virtual DbSet<PingBiao_Eval_QingDanFYDBMX> PingBiao_Eval_QingDanFYDBMX { get; set; }
        public virtual DbSet<PingBiao_Eval_QingDanPBZX> PingBiao_Eval_QingDanPBZX { get; set; }
        public virtual DbSet<PingBiao_Eval_QuFeiCheck> PingBiao_Eval_QuFeiCheck { get; set; }
        public virtual DbSet<PingBiao_Eval_QuFeiTZ> PingBiao_Eval_QuFeiTZ { get; set; }
        public virtual DbSet<PingBiao_Eval_SysSet> PingBiao_Eval_SysSet { get; set; }
        public virtual DbSet<PingBiao_Eval_TouBiaoJGFX> PingBiao_Eval_TouBiaoJGFX { get; set; }
        public virtual DbSet<PingBiao_Eval_TouBiaoZJ> PingBiao_Eval_TouBiaoZJ__ { get; set; }
        public virtual DbSet<PingBiao_Eval_ZHDJDetail> PingBiao_Eval_ZHDJDetail { get; set; }
        public virtual DbSet<PingBiao_Eval_ZuiZhongJGB> PingBiao_Eval_ZuiZhongJGB { get; set; }
        public virtual DbSet<PingBiao_Extend> PingBiao_Extend { get; set; }
        public virtual DbSet<PingBiao_Extend1> PingBiao_Extend1 { get; set; }
        public virtual DbSet<PingBiao_FeiBiao> PingBiao_FeiBiao { get; set; }
        public virtual DbSet<PingBiao_GcZbXm> PingBiao_GcZbXm { get; set; }
        public virtual DbSet<PingBiao_Helpknowledge> PingBiao_Helpknowledge { get; set; }
        public virtual DbSet<PingBiao_HistoryDBConfig> PingBiao_HistoryDBConfig { get; set; }
        public virtual DbSet<PingBiao_HistroyOfCBS> PingBiao_HistroyOfCBS { get; set; }
        public virtual DbSet<PingBiao_IPArea> PingBiao_IPArea { get; set; }
        public virtual DbSet<PingBiao_KaiBiaoTouBiao> PingBiao_KaiBiaoTouBiao { get; set; }
        public virtual DbSet<PingBiao_MeetIng> PingBiao_MeetIng { get; set; }
        public virtual DbSet<PingBiao_Menu_Category> PingBiao_Menu_Category { get; set; }
        public virtual DbSet<PingBiao_MoveDataerror> PingBiao_MoveDataerror { get; set; }
        public virtual DbSet<PingBiao_MoveDataLog> PingBiao_MoveDataLog { get; set; }
        public virtual DbSet<PingBiao_MsgCenter> PingBiao_MsgCenter { get; set; }
        public virtual DbSet<PingBiao_Operation> PingBiao_Operation { get; set; }
        public virtual DbSet<PingBiao_Parameter> PingBiao_Parameter { get; set; }
        public virtual DbSet<PingBiao_PB_ZHDJ_XuanDingQD> PingBiao_PB_ZHDJ_XuanDingQD { get; set; }
        public virtual DbSet<PingBiao_PBBF_PSYS> PingBiao_PBBF_PSYS { get; set; }
        public virtual DbSet<PingBiao_PBFlowSet> PingBiao_PBFlowSet { get; set; }
        public virtual DbSet<PingBiao_PF_ZHDJMB> PingBiao_PF_ZHDJMB { get; set; }
        public virtual DbSet<PingBiao_PF_ZHDJQD> PingBiao_PF_ZHDJQD { get; set; }
        public virtual DbSet<PingBiao_PF_ZHDJSZ> PingBiao_PF_ZHDJSZ { get; set; }
        public virtual DbSet<PingBiao_PFD> PingBiao_PFD { get; set; }
        public virtual DbSet<PingBiao_PFD_URL2> PingBiao_PFD_URL2 { get; set; }
        public virtual DbSet<PingBiao_PFDLastMark> PingBiao_PFDLastMark_ { get; set; }
        public virtual DbSet<PingBiao_PingBiaoPeople> PingBiao_PingBiaoPeople { get; set; }
        public virtual DbSet<PingBiao_PingFenPingWeiInfo> PingBiao_PingFenPingWeiInfo { get; set; }
        public virtual DbSet<PingBiao_PW_AllowAccess> PingBiao_PW_AllowAccess { get; set; }
        public virtual DbSet<PingBiao_PW_LoginInfo> PingBiao_PW_LoginInfo { get; set; }
        public virtual DbSet<PingBiao_Pw_Mark> PingBiao_Pw_Mark { get; set; }
        public virtual DbSet<PingBiao_Pw_MarkTime> PingBiao_Pw_MarkTime_ { get; set; }
        public virtual DbSet<PingBiao_Pw_TuiJianFZR> PingBiao_Pw_TuiJianFZR { get; set; }
        public virtual DbSet<PingBiao_PW_YiJian> PingBiao_PW_YiJian { get; set; }
        public virtual DbSet<PingBiao_PWCXJL> PingBiao_PWCXJL { get; set; }
        public virtual DbSet<PingBiao_PWDF> PingBiao_PWDF { get; set; }
        public virtual DbSet<PingBiao_PWDFSZ> PingBiao_PWDFSZ { get; set; }
        public virtual DbSet<PingBiao_PWDFZF> PingBiao_PWDFZF { get; set; }
        public virtual DbSet<PingBiao_PWLeader_YiJian> PingBiao_PWLeader_YiJian { get; set; }
        public virtual DbSet<PingBiao_PWYJ> PingBiao_PWYJ { get; set; }
        public virtual DbSet<PingBiao_QdFb> PingBiao_QdFb { get; set; }
        public virtual DbSet<PingBiao_QDImportErrorInfo> PingBiao_QDImportErrorInfo { get; set; }
        public virtual DbSet<PingBiao_QingBiaoPrint> PingBiao_QingBiaoPrint { get; set; }
        public virtual DbSet<PingBiao_QtXinXi> PingBiao_QtXinXi { get; set; }
        public virtual DbSet<PingBiao_ReportBack> PingBiao_ReportBack { get; set; }
        public virtual DbSet<PingBiao_ReportPdf> PingBiao_ReportPdf { get; set; }
        public virtual DbSet<PingBiao_TanPanRecord> PingBiao_TanPanRecord { get; set; }
        public virtual DbSet<PingBiao_TB_BaoJiaHistroyDetail> PingBiao_TB_BaoJiaHistroyDetail { get; set; }
        public virtual DbSet<PingBiao_TB_CaiLiaoZGMX> PingBiao_TB_CaiLiaoZGMX { get; set; }
        public virtual DbSet<PingBiao_TB_ClZgBt> PingBiao_TB_ClZgBt { get; set; }
        public virtual DbSet<PingBiao_TB_Csxm_Main> PingBiao_TB_Csxm_Main { get; set; }
        public virtual DbSet<PingBiao_TB_Csxm1Bt> PingBiao_TB_Csxm1Bt { get; set; }
        public virtual DbSet<PingBiao_TB_Csxm1Mx> PingBiao_TB_Csxm1Mx { get; set; }
        public virtual DbSet<PingBiao_TB_Dlxm> PingBiao_TB_Dlxm { get; set; }
        public virtual DbSet<PingBiao_TB_DXGCFHZ> PingBiao_TB_DXGCFHZ { get; set; }
        public virtual DbSet<PingBiao_TB_FbrgyclMx> PingBiao_TB_FbrgyclMx { get; set; }
        public virtual DbSet<PingBiao_TB_FeiYongWJ> PingBiao_TB_FeiYongWJ { get; set; }
        public virtual DbSet<PingBiao_TB_FywjMx> PingBiao_TB_FywjMx { get; set; }
        public virtual DbSet<PingBiao_TB_Gcslbmx> PingBiao_TB_Gcslbmx { get; set; }
        public virtual DbSet<PingBiao_TB_JiRiGBT> PingBiao_TB_JiRiGBT { get; set; }
        public virtual DbSet<PingBiao_TB_JiRiGMX> PingBiao_TB_JiRiGMX { get; set; }
        public virtual DbSet<PingBiao_TB_LxgzBt> PingBiao_TB_LxgzBt { get; set; }
        public virtual DbSet<PingBiao_TB_LxgzMx> PingBiao_TB_LxgzMx { get; set; }
        public virtual DbSet<PingBiao_TB_MeasureItem> PingBiao_TB_MeasureItem { get; set; }
        public virtual DbSet<PingBiao_TB_MeasureItemDERCJHL> PingBiao_TB_MeasureItemDERCJHL { get; set; }
        public virtual DbSet<PingBiao_TB_MeasureItemDEZJ> PingBiao_TB_MeasureItemDEZJ { get; set; }
        public virtual DbSet<PingBiao_TB_MeasureItemRCJHL> PingBiao_TB_MeasureItemRCJHL { get; set; }
        public virtual DbSet<PingBiao_TB_OtherItem> PingBiao_TB_OtherItem { get; set; }
        public virtual DbSet<PingBiao_TB_PingShenCL> PingBiao_TB_PingShenCL { get; set; }
        public virtual DbSet<PingBiao_TB_QdCSBT> PingBiao_TB_QdCSBT { get; set; }
        public virtual DbSet<PingBiao_TB_QdCSData> PingBiao_TB_QdCSData { get; set; }
        public virtual DbSet<PingBiao_TB_QdFb> PingBiao_TB_QdFb { get; set; }
        public virtual DbSet<PingBiao_TB_Qdxdercjhl> PingBiao_TB_Qdxdercjhl { get; set; }
        public virtual DbSet<PingBiao_TB_QingDanItem> PingBiao_TB_QingDanItem { get; set; }
        public virtual DbSet<PingBiao_TB_QingDanItemDERCJHL> PingBiao_TB_QingDanItemDERCJHL { get; set; }
        public virtual DbSet<PingBiao_TB_QingDanItemDEZJ> PingBiao_TB_QingDanItemDEZJ { get; set; }
        public virtual DbSet<PingBiao_TB_QingDanItemRCJHL> PingBiao_TB_QingDanItemRCJHL { get; set; }
        public virtual DbSet<PingBiao_TB_RcjhzMx> PingBiao_TB_RcjhzMx { get; set; }
        public virtual DbSet<PingBiao_TB_Resource> PingBiao_TB_Resource { get; set; }
        public virtual DbSet<PingBiao_TB_TechCSBT> PingBiao_TB_TechCSBT { get; set; }
        public virtual DbSet<PingBiao_TB_TechCSData> PingBiao_TB_TechCSData { get; set; }
        public virtual DbSet<PingBiao_TB_TechFile> PingBiao_TB_TechFile_ { get; set; }
        public virtual DbSet<PingBiao_TB_TechTreeList> PingBiao_TB_TechTreeList { get; set; }
        public virtual DbSet<PingBiao_TB_ZanLieJEMX> PingBiao_TB_ZanLieJEMX { get; set; }
        public virtual DbSet<PingBiao_TB_ZbgyclMx> PingBiao_TB_ZbgyclMx { get; set; }
        public virtual DbSet<PingBiao_TB_ZbgySbMx> PingBiao_TB_ZbgySbMx { get; set; }
        public virtual DbSet<PingBiao_TB_ZbgyssMx> PingBiao_TB_ZbgyssMx { get; set; }
        public virtual DbSet<PingBiao_TB_ZhuanYeGCZGJMX> PingBiao_TB_ZhuanYeGCZGJMX { get; set; }
        public virtual DbSet<PingBiao_TB_ZongChengBFWFMX> PingBiao_TB_ZongChengBFWFMX { get; set; }
        public virtual DbSet<PingBiao_TBExtInfoMx> PingBiao_TBExtInfoMx { get; set; }
        public virtual DbSet<PingBiao_TBFile_Deviation> PingBiao_TBFile_Deviation { get; set; }
        public virtual DbSet<PingBiao_TBInfoMx> PingBiao_TBInfoMx { get; set; }
        public virtual DbSet<PingBiao_TBNetFileInfo> PingBiao_TBNetFileInfo { get; set; }
        public virtual DbSet<PingBiao_TechFileLTX> PingBiao_TechFileLTX { get; set; }
        public virtual DbSet<PingBiao_TechLastMark> PingBiao_TechLastMark { get; set; }
        public virtual DbSet<PingBiao_TouBiao_DetailBaoJia> PingBiao_TouBiao_DetailBaoJia { get; set; }
        public virtual DbSet<PingBiao_XmjlDaBian> PingBiao_XmjlDaBian { get; set; }
        public virtual DbSet<PingBiao_YiChang> PingBiao_YiChang { get; set; }
        public virtual DbSet<PingBiao_ZB_Cad> PingBiao_ZB_Cad { get; set; }
        public virtual DbSet<PingBiao_ZB_CaiLiaoZGMX> PingBiao_ZB_CaiLiaoZGMX { get; set; }
        public virtual DbSet<PingBiao_ZB_DanWeiGC> PingBiao_ZB_DanWeiGC { get; set; }
        public virtual DbSet<PingBiao_ZB_Dlxm> PingBiao_ZB_Dlxm { get; set; }
        public virtual DbSet<PingBiao_ZB_EconomicPBBF> PingBiao_ZB_EconomicPBBF { get; set; }
        public virtual DbSet<PingBiao_ZB_FBTK> PingBiao_ZB_FBTK { get; set; }
        public virtual DbSet<PingBiao_ZB_FileTender> PingBiao_ZB_FileTender { get; set; }
        public virtual DbSet<PingBiao_ZB_Gcslbmx> PingBiao_ZB_Gcslbmx { get; set; }
        public virtual DbSet<PingBiao_ZB_GcxmzjbMx> PingBiao_ZB_GcxmzjbMx { get; set; }
        public virtual DbSet<PingBiao_ZB_JiaGongCL> PingBiao_ZB_JiaGongCL { get; set; }
        public virtual DbSet<PingBiao_ZB_JiRiGBT> PingBiao_ZB_JiRiGBT { get; set; }
        public virtual DbSet<PingBiao_ZB_JiRiGMX> PingBiao_ZB_JiRiGMX { get; set; }
        public virtual DbSet<PingBiao_ZB_LxgzBt> PingBiao_ZB_LxgzBt { get; set; }
        public virtual DbSet<PingBiao_ZB_LxgzMx> PingBiao_ZB_LxgzMx { get; set; }
        public virtual DbSet<PingBiao_ZB_Mark> PingBiao_ZB_Mark { get; set; }
        public virtual DbSet<PingBiao_ZB_MeasureItem> PingBiao_ZB_MeasureItem { get; set; }
        public virtual DbSet<PingBiao_ZB_MeasureItem_Main> PingBiao_ZB_MeasureItem_Main { get; set; }
        public virtual DbSet<PingBiao_ZB_NetFile> PingBiao_ZB_NetFile { get; set; }
        public virtual DbSet<PingBiao_ZB_OtherItem> PingBiao_ZB_OtherItem { get; set; }
        public virtual DbSet<PingBiao_ZB_PingShenCL> PingBiao_ZB_PingShenCL { get; set; }
        public virtual DbSet<PingBiao_ZB_QdCSBT> PingBiao_ZB_QdCSBT { get; set; }
        public virtual DbSet<PingBiao_ZB_QdCSData> PingBiao_ZB_QdCSData { get; set; }
        public virtual DbSet<PingBiao_ZB_QingDanItem> PingBiao_ZB_QingDanItem { get; set; }
        public virtual DbSet<PingBiao_ZB_QingDanItem_BiaoTi> PingBiao_ZB_QingDanItem_BiaoTi { get; set; }
        public virtual DbSet<PingBiao_ZB_RcjhzMx> PingBiao_ZB_RcjhzMx_ { get; set; }
        public virtual DbSet<PingBiao_ZB_TechCSBT> PingBiao_ZB_TechCSBT { get; set; }
        public virtual DbSet<PingBiao_ZB_TechCSData> PingBiao_ZB_TechCSData { get; set; }
        public virtual DbSet<PingBiao_ZB_TechFile> PingBiao_ZB_TechFile { get; set; }
        public virtual DbSet<PingBiao_ZB_ZanLieJEMX> PingBiao_ZB_ZanLieJEMX { get; set; }
        public virtual DbSet<PingBiao_ZB_ZbgyclMx> PingBiao_ZB_ZbgyclMx { get; set; }
        public virtual DbSet<PingBiao_ZB_ZbgySbMx> PingBiao_ZB_ZbgySbMx { get; set; }
        public virtual DbSet<PingBiao_ZB_ZbgyssMx> PingBiao_ZB_ZbgyssMx { get; set; }
        public virtual DbSet<PingBiao_ZB_ZhuanYeGCZGJ> PingBiao_ZB_ZhuanYeGCZGJ { get; set; }
        public virtual DbSet<PingBiao_ZB_ZongChengBFWFMX> PingBiao_ZB_ZongChengBFWFMX { get; set; }
        public virtual DbSet<PingBiao_ZBFileInfo> PingBiao_ZBFileInfo { get; set; }
        public virtual DbSet<PingBiao_ZBInfoMx> PingBiao_ZBInfoMx { get; set; }
        public virtual DbSet<PingBiao_ZhiXun> PingBiao_ZhiXun { get; set; }
        public virtual DbSet<PingBiao_ZiShenReason> PingBiao_ZiShenReason { get; set; }
        public virtual DbSet<PingBiao_ZongHeUnitFX> PingBiao_ZongHeUnitFX { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<CmsDbContext>(null);
            //Database.SetInitializer<PBDbContext>(new CreateDatabaseIfNotExists<PBDbContext>());
            Database.SetInitializer<PBDbContext>(new MigrateDatabaseToLatestVersion<PBDbContext, Migrations.Configuration>());
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<PingBiao_BiaoDuan>()
            //    .Property(e => e.TuiJianPwFzrNo)
            //    .HasPrecision(2, 0);

            //modelBuilder.Entity<PingBiao_BiaoDuan>()
            //    .Property(e => e.ControlPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Answer>()
            //    .Property(e => e.AnswerMark)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Evak_PbDetail>()
            //    .Property(e => e.MinDF)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Evak_PbDetail>()
            //    .Property(e => e.MaxDF)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BaojiaMark>()
            //    .Property(e => e.ChaElv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_BaojiaMark>()
            //    .Property(e => e.DlxmPoint)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BaojiaMark>()
            //    .Property(e => e.NoDlxmPoint)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.TotalPrice_BiaoDi)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.UnitPrice_Avg)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.TotalPrice_Avg)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.UnitPrice_CiLeast)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.TotalPrice_CiLeast)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.UnitPrice_Least)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.TotalPrice_Least)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.UnitPrice_Max)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.TotalPrice_Max)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice>()
            //    .Property(e => e.UnitPrice_BiaoDi)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice_MeasureItem>()
            //    .Property(e => e.TotalPrice_Avg)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice_MeasureItem>()
            //    .Property(e => e.TotalPrice_BiaoDi)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice_MeasureItem>()
            //    .Property(e => e.TotalPrice_CiLeast)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BasePrice_MeasureItem>()
            //    .Property(e => e.TotalPrice_Least)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_BiaoJiaBJB>()
            //    .Property(e => e.BiaoDiTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.JE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.BiaoDiUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.BiaoDi_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.BiaoDi_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.AvgUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.Avg_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.Avg_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.LeastUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.Least_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.Least_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.CiLeastUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.CiLeast_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_CSFX>()
            //    .Property(e => e.CiLeast_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_DiYuCBJPD>()
            //    .Property(e => e.ZongHeUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_DiYuCBJPD>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_DiYuCBJPD>()
            //    .Property(e => e.TotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_DiYuCBJPD>()
            //    .Property(e => e.TouBiaoPriceMax)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_DiYuCBJPD>()
            //    .Property(e => e.ChaE)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_DlxmAccordCheck>()
            //    .Property(e => e.TiaoZhengTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.JE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.BiaoDiUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.BiaoDi_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.BiaoDi_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.AvgUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.Avg_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.Avg_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.LeastUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.Least_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.Least_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.CiLeastUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.CiLeast_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_DXGCFX>()
            //    .Property(e => e.CiLeast_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_FywjMxMathErrorTZ>()
            //    .Property(e => e.Je)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<PingBiao_Eval_FywjMxMathErrorTZ>()
            //    .Property(e => e.Zgj)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei1)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei2)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei3)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei4)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei5)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei6)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei7)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei8)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei9)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei10)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei11)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei12)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei13)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei14)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei15)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei16)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei17)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei18)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei19)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei20)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei21)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiDefault>()
            //    .Property(e => e.Guifei22)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiList>()
            //    .Property(e => e.Je)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiList>()
            //    .Property(e => e.Fl)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei1)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei2)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei3)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei4)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei5)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei6)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei7)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei8)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei9)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei10)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei11)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei12)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei13)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei14)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei15)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei16)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei17)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei18)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei19)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_GuifeiProjectSet>()
            //    .Property(e => e.Guifei20)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.UnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.TotalPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.CalTotalPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.TiaoZhengPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.OverheadUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.Profit)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.LaborUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.MaterialUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.MachineUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrors>()
            //    .Property(e => e.RiskUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrorTZ>()
            //    .Property(e => e.UnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrorTZ>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrorTZ>()
            //    .Property(e => e.TotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrorTZ>()
            //    .Property(e => e.CalTotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MathErrorTZ>()
            //    .Property(e => e.TiaoZhengPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MeasureAccordCheck>()
            //    .Property(e => e.TiaoZhengTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItem>()
            //    .Property(e => e.BiaoDi_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItem>()
            //    .Property(e => e.Least_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItem>()
            //    .Property(e => e.CiLeast_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItem>()
            //    .Property(e => e.Avg_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItemBJ>()
            //    .Property(e => e.HanLiang)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItemBJ>()
            //    .Property(e => e.Avg_ChaELV)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItemBJ>()
            //    .Property(e => e.Least_ChaE)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItemBJ>()
            //    .Property(e => e.Least_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItemBJ>()
            //    .Property(e => e.CiLeastTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItemBJ>()
            //    .Property(e => e.CiDiLeast_ChaE)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItemBJ>()
            //    .Property(e => e.CiDiLeast_ChaELV)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItemBJ>()
            //    .Property(e => e.BiaoDi_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_Eval_MeasureItemBJ>()
            //    .Property(e => e.MeasueTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_OtherAccordCheck>()
            //    .Property(e => e.TiaoZhengTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanAccordCheck>()
            //    .Property(e => e.TiaoZhengTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.ZongHeUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.ZongHeUnitPrice_DB)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.ZongHeUnitPriceChaElv)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.OverHeadUnitPriceChaElv)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.MachineUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.MachineUnitPrice_DB)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.MachineUnitPriceChaElv)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.MaterialUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.MaterialUnitPrice_DB)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.MaterialUnitPriceChaElv)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.LaborUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.LaborUnitPrice_DB)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.LaborUnitPriceChaElv)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.OverHeadUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QingDanFYDBMX>()
            //    .Property(e => e.OverHeadUnitPrice_DB)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_QuFeiCheck>()
            //    .Property(e => e.QuFeiJS)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_QuFeiCheck>()
            //    .Property(e => e.FeiLv)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_QuFeiCheck>()
            //    .Property(e => e.TouBiaoPriced)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_QuFeiCheck>()
            //    .Property(e => e.GuiDingFl)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_Eval_QuFeiCheck>()
            //    .Property(e => e.CalPrice)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_QuFeiCheck>()
            //    .Property(e => e.TiaoZhengPrice)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_QuFeiTZ>()
            //    .Property(e => e.QuFeiJS)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_QuFeiTZ>()
            //    .Property(e => e.TiaoZhengPrice)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_TouBiaoJGFX>()
            //    .Property(e => e.QingDanFei)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_TouBiaoJGFX>()
            //    .Property(e => e.MeasureFei)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_TouBiaoJGFX>()
            //    .Property(e => e.OtherFei)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_TouBiaoJGFX>()
            //    .Property(e => e.GuiFei)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_TouBiaoJGFX>()
            //    .Property(e => e.ShuiJin)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_TouBiaoJGFX>()
            //    .Property(e => e.TotalPrice)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_Eval_ZuiZhongJGB>()
            //    .Property(e => e.GuiFei)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_ZuiZhongJGB>()
            //    .Property(e => e.ShuiJin)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_ZuiZhongJGB>()
            //    .Property(e => e.TouBiaoJG)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_ZuiZhongJGB>()
            //    .Property(e => e.CuoShiF)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Eval_ZuiZhongJGB>()
            //    .Property(e => e.AnQuanFei)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend1)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend2)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend3)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend4)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend5)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend6)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend7)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend8)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend10)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend9)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend11)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend12)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend13)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Extend>()
            //    .Property(e => e.Extend14)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_HistroyOfCBS>()
            //    .Property(e => e.TouBiaoTotal)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_KaiBiaoTouBiao>()
            //    .Property(e => e.TbrRlv)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Parameter>()
            //    .Property(e => e.PageKF)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Parameter>()
            //    .Property(e => e.NoDlxmJzzRlv)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Parameter>()
            //    .Property(e => e.Rate)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Parameter>()
            //    .Property(e => e.DlxmJZZ)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PB_ZHDJ_XuanDingQD>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.ZongHeUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.BiaoDiUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.BiaoDi_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.BiaoDi_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.AvgUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.Avg_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.Avg_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.LeastUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.Least_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.Least_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.CiLeastUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.CiLeast_ChaE)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.CiLeast_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.LaborUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.MaterialUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.MachineUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.OverheadUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.Profit)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.RiskUnitPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.ZongHeTotalPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.BiaoDiTotalPrice)
            //    .HasPrecision(19, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.AvgTotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.LeastTotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.CiLeastTotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.BiaoDiTotalPrice_ChaE)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.BiaoDiTotalPrice_ChaELv)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.AvgTotalPrice_ChaE)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.AvgTotalPrice_ChaELv)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.MaxTotalPrice)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.MaxTotalPrice_ChaE)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.CiLeastTotalPrice_ChaELv)
            //    .HasPrecision(20, 9);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.CiLeastTotalPrice_ChaE)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.LeastTotalPrice_ChaELv)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_PF_ZHDJQD>()
            //    .Property(e => e.LeastTotalPrice_ChaE)
            //    .HasPrecision(18, 5);

            //modelBuilder.Entity<PingBiao_PFD>()
            //    .Property(e => e.ZF)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_PW_LoginInfo>()
            //    .Property(e => e.Exam_Mark)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_Pw_TuiJianFZR>()
            //    .Property(e => e.TuiJianCount)
            //    .HasPrecision(3, 0);

            //modelBuilder.Entity<PingBiao_PWDF>()
            //    .Property(e => e.PianLiLv_DF)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PingBiao_QDImportErrorInfo>()
            //    .Property(e => e.BiaoDuanGuid)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PingBiao_QDImportErrorInfo>()
            //    .Property(e => e.DanWeiGuid)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PingBiao_QDImportErrorInfo>()
            //    .Property(e => e.TableName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PingBiao_QDImportErrorInfo>()
            //    .Property(e => e.ErrorData)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PingBiao_QDImportErrorInfo>()
            //    .Property(e => e.ErrorInfo)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PingBiao_TB_CaiLiaoZGMX>()
            //    .Property(e => e.Sl)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_CaiLiaoZGMX>()
            //    .Property(e => e.Dj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_CaiLiaoZGMX>()
            //    .Property(e => e.Hj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_CaiLiaoZGMX>()
            //    .Property(e => e.Hj_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_CaiLiaoZGMX>()
            //    .Property(e => e.Dj_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_CaiLiaoZGMX>()
            //    .Property(e => e.sl_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Csxm_Main>()
            //    .Property(e => e.Zgj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_Csxm1Mx>()
            //    .Property(e => e.Fl)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Csxm1Mx>()
            //    .Property(e => e.Je)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Csxm1Mx>()
            //    .Property(e => e.Js)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Csxm1Mx>()
            //    .Property(e => e.Je_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Csxm1Mx>()
            //    .Property(e => e.fl_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Csxm1Mx>()
            //    .Property(e => e.js_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Csxm1Mx>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Csxm1Mx>()
            //    .Property(e => e.Jjrg)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Dlxm>()
            //    .Property(e => e.Sl)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Dlxm>()
            //    .Property(e => e.Sl_TZ)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_DXGCFHZ>()
            //    .Property(e => e.Gf)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_DXGCFHZ>()
            //    .Property(e => e.Fyje)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_DXGCFHZ>()
            //    .Property(e => e.Zgj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_DXGCFHZ>()
            //    .Property(e => e.Aqf)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FbrgyclMx>()
            //    .Property(e => e.Sl)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FbrgyclMx>()
            //    .Property(e => e.Dj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FbrgyclMx>()
            //    .Property(e => e.Hj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FbrgyclMx>()
            //    .Property(e => e.Dj_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FbrgyclMx>()
            //    .Property(e => e.sl_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FbrgyclMx>()
            //    .Property(e => e.hj_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FeiYongWJ>()
            //    .Property(e => e.QuFeiJS)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FeiYongWJ>()
            //    .Property(e => e.FeiLv)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FeiYongWJ>()
            //    .Property(e => e.TotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FywjMx>()
            //    .Property(e => e.zgj_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FywjMx>()
            //    .Property(e => e.Je)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FywjMx>()
            //    .Property(e => e.Zgj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_FywjMx>()
            //    .Property(e => e.Je_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_JiRiGBT>()
            //    .Property(e => e.je_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_JiRiGMX>()
            //    .Property(e => e.ZdSl)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_JiRiGMX>()
            //    .Property(e => e.Zhdj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_JiRiGMX>()
            //    .Property(e => e.Zhhj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_JiRiGMX>()
            //    .Property(e => e.ZdSl_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_JiRiGMX>()
            //    .Property(e => e.Zhdj_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_JiRiGMX>()
            //    .Property(e => e.Zhhj_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.ZongHeUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.ZongHeTotalPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.Zgj_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.Quantity_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.LaborUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.MaterialUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.MachineUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.OverheadUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.Profit_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.Jjrg)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.DergfDj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItem>()
            //    .Property(e => e.DergfHj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.Zcf)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.Fcf)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.MaterialUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.MachineUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.OverheadUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.Profit)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.ZongHeUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.LaborUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.RiskUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.ZongHeTotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.ZongHeFei)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.DergfDj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_MeasureItemDEZJ>()
            //    .Property(e => e.DergfHj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_OtherItem>()
            //    .Property(e => e.TotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_OtherItem>()
            //    .Property(e => e.TotalPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QdFb>()
            //    .Property(e => e.ZGJ)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Qdxdercjhl>()
            //    .Property(e => e.Hl)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_Qdxdercjhl>()
            //    .Property(e => e.Cljg)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.ZongHeUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.LaborUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.MaterialUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.MachineUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.OverheadUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Profit)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.RiskUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.ZongHeTotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Zgj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Zcf)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Fcf)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Zgr)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Quantity_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.ZongHeTotalPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.ZongHeUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.EquipmentRate)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.RestRate)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.LawfeeRate)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.TaxRate)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.LimitedRate)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Zgj_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.LaborUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.MaterialUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.MachineUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.OverheadUnitPrice_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Profit_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Jjrg)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Xmbm)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Quantity2)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Qtgcf)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Jjf)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItem>()
            //    .Property(e => e.Sj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItemDERCJHL>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItemDERCJHL>()
            //    .Property(e => e.ResourcePrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItemDEZJ>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItemDEZJ>()
            //    .Property(e => e.Qtgcf)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_QingDanItemDEZJ>()
            //    .Property(e => e.Sj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TB_Resource>()
            //    .Property(e => e.Dej)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_ZanLieJEMX>()
            //    .Property(e => e.ZdJe)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_ZanLieJEMX>()
            //    .Property(e => e.ZdJe_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_ZhuanYeGCZGJMX>()
            //    .Property(e => e.Je)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_ZhuanYeGCZGJMX>()
            //    .Property(e => e.Je_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TB_ZongChengBFWFMX>()
            //    .Property(e => e.Fl)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_TB_ZongChengBFWFMX>()
            //    .Property(e => e.je_OK)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TechFileLTX>()
            //    .Property(e => e.similarity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.TouBiaoTotal)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.QingDanTotal)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.MeasureTotal)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.OtherTotal)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.GuiFeiTotal)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.ShuiJinTotal)
            //    .HasPrecision(19, 2);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.ShuiFei_BeforeTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.GcDe_FeiTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.SafeCivilizationCost)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.MachineTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.OverheadTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.ProfitTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.TemporaryRate)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.LaborTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.MaterialTotal)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.yunfei)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.pbj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.qdhzhj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.zdjefl)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.zdjef)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_TouBiao_DetailBaoJia>()
            //    .Property(e => e.zdjhj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_ZB_CaiLiaoZGMX>()
            //    .Property(e => e.Sl)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_CaiLiaoZGMX>()
            //    .Property(e => e.Dj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_CaiLiaoZGMX>()
            //    .Property(e => e.Hj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_EconomicPBBF>()
            //    .Property(e => e.MinDF)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_EconomicPBBF>()
            //    .Property(e => e.MaxDF)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_JiaGongCL>()
            //    .Property(e => e.Dj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_JiaGongCL>()
            //    .Property(e => e.Hj)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_JiaGongCL>()
            //    .Property(e => e.Sl)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_MeasureItem>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_MeasureItem>()
            //    .Property(e => e.Zgj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_ZB_QingDanItem>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_QingDanItem>()
            //    .Property(e => e.ZongheUnitPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_QingDanItem>()
            //    .Property(e => e.ZongheTotalPrice)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_QingDanItem>()
            //    .Property(e => e.LimitedRate)
            //    .HasPrecision(22, 9);

            //modelBuilder.Entity<PingBiao_ZB_QingDanItem>()
            //    .Property(e => e.zgj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_ZB_QingDanItem>()
            //    .Property(e => e.ZongHeFei)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_ZB_QingDanItem>()
            //    .Property(e => e.DergfDj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_ZB_QingDanItem>()
            //    .Property(e => e.DergfHj)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_ZB_QingDanItem>()
            //    .Property(e => e.Quantity2)
            //    .HasPrecision(18, 9);

            //modelBuilder.Entity<PingBiao_ZB_ZongChengBFWFMX>()
            //    .Property(e => e.Fl)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_ZongHeUnitFX>()
            //    .Property(e => e.ZongHeUnitPrice)
            //    .HasPrecision(18, 6);

            //modelBuilder.Entity<PingBiao_ZongHeUnitFX>()
            //    .Property(e => e.AvgZongHeUnitPrice)
            //    .HasPrecision(18, 6);
        }
    }
}
