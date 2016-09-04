namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_Cad : ModelBase
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        
        

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(255)]
        public string CADTenderName { get; set; }

        [StringLength(255)]
        public string MuLuName { get; set; }

        [StringLength(255)]
        public string CADFileName { get; set; }

        public int? CADTenderLx { get; set; }

        [StringLength(10)]
        public string NO { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        public int? CADFileLx { get; set; }

        [StringLength(50)]
        public string CADCliengGuid { get; set; }
    }
}
