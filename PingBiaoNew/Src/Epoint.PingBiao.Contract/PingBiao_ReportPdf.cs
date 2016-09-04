namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ReportPdf : ModelBase
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string ReportType { get; set; }

        [StringLength(50)]
        public string PwGuid { get; set; }

        [StringLength(50)]
        public string ReportGuid { get; set; }

        [StringLength(50)]
        public string Attach_ConnectionStringName { get; set; }

        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "image")]
        public byte[] ReportImage { get; set; }

        [StringLength(50)]
        public string ReportCategory { get; set; }
    }
}
