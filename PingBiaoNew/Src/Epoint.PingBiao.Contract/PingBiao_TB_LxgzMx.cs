namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_LxgzMx
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

        [Column(TypeName = "numeric")]
        public decimal? Sl { get; set; }

        [StringLength(50)]
        public string Xh { get; set; }

        [StringLength(50)]
        public string Mc { get; set; }

        [StringLength(50)]
        public string Xhgg { get; set; }

        [StringLength(50)]
        public string Dw { get; set; }

        [StringLength(50)]
        public string DanWeiGCName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zhdj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zhhj { get; set; }

        [StringLength(50)]
        public string Bz { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string DanWeiName { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }
    }
}
