namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Extend1 : ModelBase
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

        [StringLength(200)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(4000)]
        public string Extend1 { get; set; }

        [StringLength(4000)]
        public string Extend2 { get; set; }

        [StringLength(4000)]
        public string Extend3 { get; set; }

        [StringLength(4000)]
        public string Extend4 { get; set; }

        [StringLength(4000)]
        public string Extend5 { get; set; }

        [StringLength(4000)]
        public string Extend6 { get; set; }

        [StringLength(4000)]
        public string Extend7 { get; set; }
    }
}
