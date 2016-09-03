namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_FbrgyclMx
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

        [StringLength(255)]
        public string Bz { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(20)]
        public string Xh { get; set; }

        [StringLength(20)]
        public string RcjId { get; set; }

        [StringLength(20)]
        public string Clbh { get; set; }

        [StringLength(255)]
        public string Mc { get; set; }

        [StringLength(255)]
        public string Ggxh { get; set; }

        [StringLength(20)]
        public string Dw { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Dj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Hj { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(2)]
        public string DuoQueX { get; set; }

        [StringLength(2)]
        public string ISValidCheckTZ { get; set; }

        [StringLength(2)]
        public string Is_Error_TZ { get; set; }

        [StringLength(20)]
        public string Dw_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Dj_OK { get; set; }

        [StringLength(2)]
        public string ISBiaoDi { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }

        [StringLength(255)]
        public string Mc_OK { get; set; }

        [StringLength(255)]
        public string Ggxh_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sl_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? hj_OK { get; set; }

        [StringLength(50)]
        public string IsPs { get; set; }
    }
}
