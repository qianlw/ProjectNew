namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZBInfoMx
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

        [StringLength(255)]
        public string BookMarkName { get; set; }

        public int? Xh { get; set; }

        [Column(TypeName = "ntext")]
        public string MarkValue { get; set; }

        [StringLength(50)]
        public string MarkType { get; set; }

        [StringLength(50)]
        public string Attribute1 { get; set; }

        [StringLength(50)]
        public string Attribute2 { get; set; }

        [StringLength(50)]
        public string Attribute3 { get; set; }
    }
}
