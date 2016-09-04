namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_TechTreeList : ModelBase
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

        [StringLength(50)]
        public string Suffix { get; set; }

        public int? NodePage { get; set; }

        [StringLength(50)]
        public string NodeType { get; set; }

        [StringLength(50)]
        public string IsAttachFile { get; set; }

        [StringLength(50)]
        public string FileGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        public int? TreeNodeID { get; set; }

        [StringLength(500)]
        public string TreeNodeName { get; set; }

        public int? TreeNodeDepth { get; set; }

        public int? TreeNodeParent { get; set; }

        [StringLength(50)]
        public string PFDGuid { get; set; }
    }
}
