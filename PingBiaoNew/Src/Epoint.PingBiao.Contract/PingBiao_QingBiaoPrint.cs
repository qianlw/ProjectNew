namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_QingBiaoPrint : ModelBase
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

        [StringLength(250)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(10)]
        public string type { get; set; }

        [StringLength(10)]
        public string dx { get; set; }

        [StringLength(10)]
        public string qx { get; set; }

        [StringLength(10)]
        public string mc { get; set; }

        [StringLength(10)]
        public string sl { get; set; }

        [StringLength(10)]
        public string dw { get; set; }

        [StringLength(10)]
        public string je { get; set; }

        [StringLength(100)]
        public string lb { get; set; }

        [StringLength(150)]
        public string bz1 { get; set; }

        [StringLength(150)]
        public string bz2 { get; set; }

        [StringLength(150)]
        public string bz3 { get; set; }

        [StringLength(150)]
        public string bz4 { get; set; }

        [StringLength(150)]
        public string bz5 { get; set; }
    }
}
