namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_EconomicPBBF
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

        [Column(TypeName = "numeric")]
        public decimal? ZF { get; set; }

        [StringLength(50)]
        public string IsGSJZZ { get; set; }

        [Column(TypeName = "ntext")]
        public string GSShuoming { get; set; }

        public int? TBRLimit { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pjzxs { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sfkf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Xfkf { get; set; }

        public int? RemoveMax { get; set; }

        public int? RemoveMin { get; set; }

        [StringLength(255)]
        public string Psys { get; set; }

        [StringLength(255)]
        public string JZZGS { get; set; }

        public int? IsZJF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MinDF { get; set; }

        [StringLength(255)]
        public string GS { get; set; }

        public int? AutoCalc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxDF { get; set; }

        [StringLength(255)]
        public string Parent_Psys { get; set; }

        [StringLength(10)]
        public string Xh { get; set; }
    }
}
