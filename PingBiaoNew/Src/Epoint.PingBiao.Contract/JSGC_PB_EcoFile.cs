namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JSGC_PB_EcoFile : ModelBase
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
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [Column(TypeName = "xml")]
        public string XmlContent { get; set; }

        [Column(TypeName = "xml")]
        public string QingDanItemRcjhlContent { get; set; }

        [Column(TypeName = "xml")]
        public string RcjhzMxContent { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(500)]
        public string DanWeiGCName { get; set; }
    }
}
