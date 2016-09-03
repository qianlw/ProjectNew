namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PW_YiJian
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

        [StringLength(3000)]
        public string PingShenContent { get; set; }

        [StringLength(50)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string PingWeiName { get; set; }

        [StringLength(50)]
        public string IsZuZhang { get; set; }

        [StringLength(50)]
        public string PingBiaoType { get; set; }
    }
}
