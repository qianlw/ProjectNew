namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_QdFb
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        [Key]
        [Column(Order = 0)]
        public int Row_ID { get; set; }

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(50)]
        public string Xh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Mc { get; set; }

        [Column(TypeName = "ntext")]
        public string Bz { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Je { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZGJ { get; set; }

        [StringLength(50)]
        public string Bm { get; set; }

        [StringLength(500)]
        public string Code { get; set; }

        [StringLength(3000)]
        public string Jsgs { get; set; }

        [StringLength(50)]
        public string Lb { get; set; }
    }
}
