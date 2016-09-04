namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_GuifeiList : ModelBase
    {
        [Column(TypeName = "numeric")]
        public decimal? Je { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        public int? GuifeiId { get; set; }

        [StringLength(255)]
        public string GuifeiName { get; set; }

        [StringLength(50)]
        public string GuifeiType { get; set; }

        [StringLength(50)]
        public string GuifeiLb { get; set; }

        [StringLength(50)]
        public string GuifeiBase { get; set; }

        [StringLength(50)]
        public string Xh { get; set; }

        [StringLength(255)]
        public string JsJc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fl { get; set; }

        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(250)]
        public string CostCode { get; set; }

        [StringLength(250)]
        public string GuiFeiFormulaParams { get; set; }
    }
}
