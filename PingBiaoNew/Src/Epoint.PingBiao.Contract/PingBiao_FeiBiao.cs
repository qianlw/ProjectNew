namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_FeiBiao
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
        public string Pw_Guid { get; set; }

        public int? FeiBiao_Count { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(250)]
        public string Pw_Name { get; set; }

        [StringLength(500)]
        public string FeiBiaoReason { get; set; }

        [StringLength(100)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
