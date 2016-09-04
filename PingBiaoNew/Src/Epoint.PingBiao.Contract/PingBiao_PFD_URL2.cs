namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PFD_URL2 : ModelBase
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
        public string UrlName { get; set; }

        [StringLength(255)]
        public string UrlAddr { get; set; }

        [Column(TypeName = "ntext")]
        public string Remark1 { get; set; }

        [Column(TypeName = "ntext")]
        public string Remark2 { get; set; }

        public int? UrlCatalog { get; set; }
    }
}
