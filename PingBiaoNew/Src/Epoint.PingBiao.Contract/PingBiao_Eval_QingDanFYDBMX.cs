namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_QingDanFYDBMX : ModelBase
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
        public string BiaoDuanGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPrice_DB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPriceChaElv { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverHeadUnitPriceChaElv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MachineUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MachineUnitPrice_DB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MachineUnitPriceChaElv { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid_DB { get; set; }

        [StringLength(255)]
        public string DanWeiName_DB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialUnitPrice { get; set; }

        [StringLength(50)]
        public string QingDanNO { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialUnitPrice_DB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaterialUnitPriceChaElv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LaborUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LaborUnitPrice_DB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LaborUnitPriceChaElv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverHeadUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OverHeadUnitPrice_DB { get; set; }

        [StringLength(500)]
        public string QingDanName { get; set; }
    }
}
