namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_Gcslbmx
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

        public int? Xh { get; set; }

        [StringLength(250)]
        public string Mc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? YZF { get; set; }

        [StringLength(2)]
        public string Lb { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(500)]
        public string DanWeiName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cgbgf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Qtzjf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Xcglf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Jjf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Lr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sj { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }
    }
}
