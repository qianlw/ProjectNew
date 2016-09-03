namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_XmjlDaBian
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
        public string PwGuid { get; set; }

        [StringLength(2)]
        public string IsUsed { get; set; }

        [StringLength(50)]
        public string Pw_Name { get; set; }

        [StringLength(50)]
        public string TiChuTime { get; set; }

        [StringLength(2500)]
        public string ZZXiuGai { get; set; }

        [StringLength(50)]
        public string IsXiuGaiQuestion { get; set; }

        [StringLength(500)]
        public string XiuGaiReason { get; set; }

        [StringLength(255)]
        public string LimitTime { get; set; }

        [StringLength(50)]
        public string DaBianDate { get; set; }

        [StringLength(2500)]
        public string Questiontext { get; set; }
    }
}
