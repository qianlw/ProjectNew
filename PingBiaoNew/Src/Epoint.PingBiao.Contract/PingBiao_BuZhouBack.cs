namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_BuZhouBack : ModelBase
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

        [StringLength(50)]
        public string xh { get; set; }

        [StringLength(50)]
        public string PFDValue { get; set; }

        [StringLength(50)]
        public string PBBF { get; set; }

        [StringLength(50)]
        public string FeiBiaoJieDianName { get; set; }

        [StringLength(1000)]
        public string PFDName { get; set; }
    }
}
