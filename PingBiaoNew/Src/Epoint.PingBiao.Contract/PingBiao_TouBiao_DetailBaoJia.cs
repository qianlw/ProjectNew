namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TouBiao_DetailBaoJia : ModelBase
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

        [StringLength(255)]
        public string DanWeiGcNO { get; set; }

        [StringLength(255)]
        public string DanWeiGcName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiaoTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QingDanTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MeasureTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OtherTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GuiFeiTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ShuiJinTotal { get; set; }

        public int? OrderNum { get; set; }

        public int? sjOrderNum { get; set; }

        [StringLength(255)]
        public string FileMiFeng { get; set; }

        [StringLength(255)]
        public string GongQi { get; set; }

        [StringLength(255)]
        public string BaoZhengJin { get; set; }

        [StringLength(255)]
        public string XiangMuJL { get; set; }

        [StringLength(255)]
        public string WuXiaoYY { get; set; }

        [StringLength(255)]
        public string FaRenDb { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        [Column(TypeName = "ntext")]
        public string ZhiLiangCN { get; set; }

        [Column(TypeName = "ntext")]
        public string BaoXiuCN { get; set; }

        [StringLength(50)]
        public string ZaoJiaRBH { get; set; }

        [StringLength(50)]
        public string ZaoJiaRXM { get; set; }

        [StringLength(50)]
        public string Dblx { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ShuiFei_BeforeTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GcDe_FeiTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SafeCivilizationCost { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MachineTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverheadTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProfitTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TemporaryRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LaborTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialTotal { get; set; }

        [StringLength(50)]
        public string IPAdress { get; set; }

        public DateTime? MakeDate { get; set; }

        [StringLength(50)]
        public string UPLoadMacAdress { get; set; }

        public DateTime? UPLoadTime { get; set; }

        [StringLength(50)]
        public string SoftName { get; set; }

        [StringLength(50)]
        public string MakeMacAdress { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zbdlf { get; set; }

        [StringLength(50)]
        public string MachineKey { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? yunfei { get; set; }

        public int? Num { get; set; }

        [StringLength(50)]
        public string Parent_No { get; set; }

        [StringLength(50)]
        public string BookMarkName { get; set; }

        [StringLength(2000)]
        public string GuiGe { get; set; }

        [StringLength(500)]
        public string ZZShName { get; set; }

        [StringLength(500)]
        public string PriceTiaojian { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pbj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? qdhzhj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? zdjefl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? zdjef { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? zdjhj { get; set; }
    }
}
