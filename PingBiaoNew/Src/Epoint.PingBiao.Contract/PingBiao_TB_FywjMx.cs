namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_FywjMx : ModelBase
    {
        [Column(TypeName = "numeric")]
        public decimal? zgj_OK { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(20)]
        public string Xh { get; set; }

        [StringLength(255)]
        public string Mc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Je { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zgj { get; set; }

        [StringLength(50)]
        public string Fyxlb { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string Zjbz { get; set; }

        [StringLength(250)]
        public string CostCode { get; set; }

        [StringLength(50)]
        public string Parent_No { get; set; }

        [StringLength(250)]
        public string SummaryFlag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Je_OK { get; set; }

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
    }
}
