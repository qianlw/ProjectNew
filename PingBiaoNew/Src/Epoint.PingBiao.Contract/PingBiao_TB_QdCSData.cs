namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_QdCSData
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

        [StringLength(250)]
        public string BookMarkName { get; set; }

        [StringLength(250)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string DanWeiGcName { get; set; }

        [StringLength(255)]
        public string DanWeiGcNo { get; set; }

        [StringLength(50)]
        public string CanShuNumber { get; set; }

        [StringLength(250)]
        public string CanShuData { get; set; }

        [StringLength(250)]
        public string BeiZhu { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string CanShuNeedQB { get; set; }

        [StringLength(250)]
        public string CanShuName { get; set; }

        [StringLength(256)]
        public string DanXiangNo { get; set; }
    }
}
