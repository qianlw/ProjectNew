namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_OtherItem
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
        public string OrderNum { get; set; }

        [StringLength(255)]
        public string OtherItemName { get; set; }

        [StringLength(50)]
        public string OtherItemType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string OtherItemType_MX { get; set; }

        [StringLength(50)]
        public string DW { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice_OK { get; set; }

        [StringLength(2)]
        public string ISValidCheckTZ { get; set; }

        [StringLength(2)]
        public string ISBiaoDi { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }
    }
}
