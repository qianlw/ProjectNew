namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_QDDFDetail
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

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(50)]
        public string QingDanNo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? JZZ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZongHeUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ChaE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ChaELv { get; set; }

        [StringLength(2)]
        public string IsError { get; set; }

        [StringLength(2)]
        public string IsConform { get; set; }

        [StringLength(2)]
        public string IsHeJia { get; set; }
    }
}
