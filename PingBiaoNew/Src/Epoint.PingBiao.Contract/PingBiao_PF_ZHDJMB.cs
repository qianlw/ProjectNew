namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PF_ZHDJMB : ModelBase
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
        public string MoBanGuid { get; set; }

        public int? OrderNumMB { get; set; }

        [StringLength(50)]
        public string MoBanName { get; set; }

        [StringLength(50)]
        public string CanShuName { get; set; }

        [StringLength(300)]
        public string CanShuBeiZhu { get; set; }

        [StringLength(50)]
        public string CanShuType { get; set; }

        public int? OrderNum { get; set; }

        [StringLength(50)]
        public string SheZhiValue { get; set; }

        [StringLength(200)]
        public string ShuoMing { get; set; }
    }
}
