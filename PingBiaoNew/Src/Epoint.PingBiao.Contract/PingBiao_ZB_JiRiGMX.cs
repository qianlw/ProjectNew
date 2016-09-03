namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_JiRiGMX
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
        public string Xh { get; set; }

        [StringLength(255)]
        public string Mc { get; set; }

        [StringLength(50)]
        public string Dw { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZdSl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zhdj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zhhj { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }

        [StringLength(500)]
        public string Parent_Qdbm { get; set; }
    }
}
