namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_BiaoJiaBJB
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
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(255)]
        public string DanWeiGcNo { get; set; }

        [StringLength(255)]
        public string DanWeiGcName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiao_QingDan { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiao_Measure { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiao_Other { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiao_GuiFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiao_ShuiJin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiao_TotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZheng_QingDan { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZheng_Measure { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZheng_Other { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZheng_GuiFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZheng_ShuiJin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZheng_TotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Last_QingDan { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Last_CuoShi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Last_Other { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Last_GuiFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Last_ShuiJin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Last_TotalPrice { get; set; }

        [StringLength(50)]
        public string ISPASS { get; set; }

        [Column(TypeName = "ntext")]
        public string Remark { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public int? OrderNum { get; set; }

        [StringLength(50)]
        public string XuHao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BiaoDiTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Last_Fee1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiao_Fee1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZheng_Fee1 { get; set; }
    }
}
