namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ChenBenJiaPSCS : ModelBase
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
        public decimal? Material_Avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? JianZhuSZ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZhuangShiAZ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Machine_Avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Machine_BiaoDi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Overhead_Avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Overhead_BiaoDi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MeasureItem_Avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MeasureItem_BiaoDi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LastCosts { get; set; }

        [StringLength(50)]
        public string IsMaxLimit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Labor_Avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Labor_BiaoDi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Labor_Limit { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZSJGC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AZJGC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SZJGC { get; set; }
    }
}
