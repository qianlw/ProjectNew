namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PingFenPingWeiInfo : ModelBase
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(50)]
        public string PingWeiType { get; set; }

        [StringLength(50)]
        public string PBBF { get; set; }

        [StringLength(50)]
        public string PingWeiTypeName { get; set; }

        [StringLength(50)]
        public string PFDValue { get; set; }

        [StringLength(50)]
        public string PFDName { get; set; }
    }
}
