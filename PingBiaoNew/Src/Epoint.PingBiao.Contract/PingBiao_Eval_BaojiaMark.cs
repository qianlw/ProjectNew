namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_BaojiaMark : ModelBase
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

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaoJiaTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaseTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ChaElv { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EconMark { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DlxmPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NoDlxmPoint { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? XDQingDanBaoJiaTotal { get; set; }

        [Column(TypeName = "ntext")]
        public string JJZCalcInfo { get; set; }

        [Column(TypeName = "ntext")]
        public string MarkCalcInfo { get; set; }
    }
}
