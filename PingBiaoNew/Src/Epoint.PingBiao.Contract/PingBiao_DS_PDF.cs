namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_DS_PDF
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

        public DateTime? DSDate { get; set; }

        [Column(TypeName = "ntext")]
        public string Signature { get; set; }

        [Column(TypeName = "image")]
        public byte[] DSPdfFile { get; set; }

        [StringLength(100)]
        public string DSPdfFile_ContentType { get; set; }

        [StringLength(100)]
        public string DSPdfFile_FileName { get; set; }

        [StringLength(50)]
        public string ReportGuid { get; set; }

        [StringLength(50)]
        public string DSGuid { get; set; }

        [StringLength(50)]
        public string DSName { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string AttachGuid { get; set; }

        [StringLength(50)]
        public string AttachConnStr { get; set; }

        [StringLength(50)]
        public string PingWeiGuid { get; set; }

        [StringLength(50)]
        public string SignAttachGuid { get; set; }

        [StringLength(50)]
        public string SignAttachConnStr { get; set; }

        [StringLength(1)]
        public string IsCombine { get; set; }

        [StringLength(50)]
        public string FileCode { get; set; }

        [StringLength(50)]
        public string ZhiXunGuid { get; set; }
    }
}
