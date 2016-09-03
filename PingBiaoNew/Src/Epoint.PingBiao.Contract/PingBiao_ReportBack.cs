namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ReportBack : ModelBase
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        public int Row_ID { get; set; }

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string FileType { get; set; }

        [StringLength(50)]
        public string QianZhangType { get; set; }

        [StringLength(50)]
        public string DoCell { get; set; }

        [StringLength(50)]
        public string CategoryNum { get; set; }

        [StringLength(50)]
        public string SysXiaQuCode { get; set; }

        [StringLength(50)]
        public string FileCode { get; set; }

        public int? X { get; set; }

        public int? Y { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FileSortId { get; set; }

        [StringLength(50)]
        public string PBBFCode { get; set; }

        [StringLength(50)]
        public string QZRY { get; set; }

        [StringLength(50)]
        public string AllowInput { get; set; }
    }
}
