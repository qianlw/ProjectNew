namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_YiChang : ModelBase
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
        public string JLR_Code { get; set; }

        [StringLength(50)]
        public string JLR_Name { get; set; }

        public DateTime? JLR_Date { get; set; }

        [Column(TypeName = "ntext")]
        public string YiChangQingKuang { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }
    }
}
