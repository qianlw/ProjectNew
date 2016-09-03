namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_OtherAccordCheck : ModelBase
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

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string XH { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        [Column(TypeName = "ntext")]
        public string ErrorContent { get; set; }

        [Column(TypeName = "ntext")]
        public string RightContent { get; set; }

        public int? ErrorNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZhengTotal { get; set; }

        [Column(TypeName = "ntext")]
        public string TiaoZhengRemark { get; set; }

        [StringLength(50)]
        public string ErrorType { get; set; }

        [StringLength(50)]
        public string ISTiaoZheng { get; set; }

        [StringLength(2000)]
        public string ErrorDescription { get; set; }

        [StringLength(50)]
        public string TiaoZhengType { get; set; }
    }
}