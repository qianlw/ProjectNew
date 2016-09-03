namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PW_LoginInfo
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
        public string Pw_Type { get; set; }

        [StringLength(50)]
        public string PW_Zy { get; set; }

        [StringLength(50)]
        public string IsZhongHePw { get; set; }

        [StringLength(2)]
        public string IsNeedHuiBi { get; set; }

        [StringLength(500)]
        public string HuiBiReason { get; set; }

        [Column(TypeName = "ntext")]
        public string ChuBuPingShenYiJian { get; set; }

        [StringLength(50)]
        public string CANumber { get; set; }

        [StringLength(50)]
        public string MechineNo { get; set; }

        [StringLength(50)]
        public string IsEcoEnd { get; set; }

        public DateTime? Pw_Birthday { get; set; }

        [StringLength(50)]
        public string Pw_ZhiCheng { get; set; }

        public DateTime? Pw_RuKuDate { get; set; }

        [StringLength(50)]
        public string IsXYXPS_TechEnd { get; set; }

        [StringLength(50)]
        public string IsFBTKPSEnd { get; set; }

        [StringLength(50)]
        public string IsXYXPSEnd { get; set; }

        [StringLength(50)]
        public string IsTechEnd { get; set; }

        [StringLength(2)]
        public string IsTuiJianFZR { get; set; }

        [StringLength(50)]
        public string IsBaoJiaHeLiXPFEnd { get; set; }

        [StringLength(50)]
        public string ChuBuPSECQR { get; set; }

        [StringLength(50)]
        public string IsChuBuPSEnd { get; set; }

        [StringLength(50)]
        public string IsQiTaEnd { get; set; }

        [StringLength(50)]
        public string IDNumber { get; set; }

        [StringLength(50)]
        public string IsZongHeBiaoEnd { get; set; }

        [StringLength(2)]
        public string IsPingJiaZBFilePass { get; set; }

        [StringLength(1000)]
        public string PingJiaZBFile { get; set; }

        [StringLength(50)]
        public string IsZiGeYSEND { get; set; }

        [StringLength(50)]
        public string IsValidCheckEnd { get; set; }

        [StringLength(50)]
        public string IsXSPSEnd { get; set; }

        [StringLength(50)]
        public string Pw_Guid { get; set; }

        [StringLength(50)]
        public string Pw_Name { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(50)]
        public string PW_LoginID { get; set; }

        public DateTime? LoginDate { get; set; }

        [StringLength(50)]
        public string IsLogin { get; set; }

        [StringLength(50)]
        public string IsPingFenEnd { get; set; }

        public DateTime? PingFenEndDate { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string PW_Password { get; set; }

        public DateTime? KaiBiaoDate { get; set; }

        [StringLength(50)]
        public string CAKey { get; set; }

        [StringLength(50)]
        public string CAGuid { get; set; }

        [StringLength(50)]
        public string CAName { get; set; }

        [StringLength(50)]
        public string CardNo { get; set; }

        [StringLength(50)]
        public string MacAddress { get; set; }

        [StringLength(50)]
        public string IsYuanChenPW { get; set; }

        [StringLength(100)]
        public string photo_ContentType { get; set; }

        [StringLength(100)]
        public string photo_FileName { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        [StringLength(50)]
        public string IsCanYuZGSC { get; set; }

        [StringLength(50)]
        public string IsYouXXShenChaEnd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Exam_Mark { get; set; }

        [StringLength(50)]
        public string Pw_Place { get; set; }

        [StringLength(50)]
        public string Biaoduanno { get; set; }

        [StringLength(50)]
        public string DLPW_type { get; set; }

        [StringLength(50)]
        public string PBTimes { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        [StringLength(50)]
        public string PWYJ { get; set; }
    }
}
