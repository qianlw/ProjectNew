namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PBBF_PSYS : ModelBase
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

        [Column(TypeName = "numeric")]
        public decimal? Xh { get; set; }

        [Column(TypeName = "ntext")]
        public string Psys { get; set; }

        [StringLength(255)]
        public string BuZhou { get; set; }

        [StringLength(50)]
        public string PingBiaoBanFa { get; set; }

        [Column(TypeName = "ntext")]
        public string Psbz { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string UserType { get; set; }
    }
}
