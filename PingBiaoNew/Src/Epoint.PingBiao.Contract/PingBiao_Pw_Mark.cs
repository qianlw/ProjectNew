namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Pw_Mark
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

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string PingWeiGuid { get; set; }

        [StringLength(50)]
        public string PFDGuid { get; set; }

        [Column(TypeName = "ntext")]
        public string MarkReason { get; set; }

        [StringLength(50)]
        public string MarkLevel { get; set; }

        [Column(TypeName = "ntext")]
        public string Bz { get; set; }

        [StringLength(50)]
        public string XiuGaiData { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PingWeiMark { get; set; }

        [StringLength(50)]
        public string PFDType { get; set; }

        [StringLength(50)]
        public string DanWeiGcName { get; set; }

        [StringLength(255)]
        public string DanWeiGcNO { get; set; }

        [StringLength(50)]
        public string QingDanNo { get; set; }

        [Column(TypeName = "ntext")]
        public string MarkReasonPic { get; set; }
    }
}
