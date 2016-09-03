namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PingBiao_PFDLastMark ")]
    public partial class PingBiao_PFDLastMark
    {
        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string PFDGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PFDLastMark { get; set; }

        [StringLength(50)]
        public string HuiZongType { get; set; }

        [StringLength(50)]
        public string PFDType { get; set; }

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

        [StringLength(200)]
        public string MarkReason { get; set; }

        [StringLength(50)]
        public string PFDLastMarkPass { get; set; }
    }
}
