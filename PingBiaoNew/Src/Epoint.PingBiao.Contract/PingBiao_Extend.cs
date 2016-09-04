namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Extend : ModelBase
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
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend8 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend10 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend9 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend11 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend12 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend13 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Extend14 { get; set; }
    }
}
