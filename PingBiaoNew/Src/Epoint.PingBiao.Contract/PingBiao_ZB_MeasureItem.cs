namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_MeasureItem : ModelBase
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        [Column(Order = 0)]
        public int Row_ID { get; set; }

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string MeasureItemType { get; set; }

        [StringLength(255)]
        public string MeasureItemName { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        [StringLength(255)]
        public string DanWeiGcNO { get; set; }

        
        [Column(Order = 1)]
        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string MeasureItemID { get; set; }

        [Column(TypeName = "ntext")]
        public string Xmtz { get; set; }

        [StringLength(10)]
        public string GCType { get; set; }

        [StringLength(250)]
        public string OrderNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zgj { get; set; }
    }
}
