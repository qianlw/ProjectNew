namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PingBiao_TB_TechFile ")]
    public partial class PingBiao_TB_TechFile : ModelBase
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
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string FuJianType { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string nType { get; set; }

        [StringLength(50)]
        public string FileGuid { get; set; }

        [StringLength(500)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string Suffix { get; set; }

        [Column(TypeName = "ntext")]
        public string BinaryFile { get; set; }

        public int? FileType { get; set; }

        [Column(TypeName = "ntext")]
        public string FileSignature { get; set; }

        [Column(TypeName = "ntext")]
        public string PbSignatureKey { get; set; }

        [StringLength(100)]
        public string FileCatalog { get; set; }

        public int? NodePage { get; set; }

        [StringLength(50)]
        public string PFCSID { get; set; }
    }
}
