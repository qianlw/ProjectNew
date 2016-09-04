namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_FormulaBase : ModelBase
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        [Column(Order = 0)]
        

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        public int? FormulaId { get; set; }

        [StringLength(50)]
        public string FormulaName { get; set; }

        
        [Column(Order = 1)]
        [StringLength(200)]
        public string Param { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(100)]
        public string XiaQuCode { get; set; }
    }
}
