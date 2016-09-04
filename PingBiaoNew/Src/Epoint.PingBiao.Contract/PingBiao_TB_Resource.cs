namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_Resource : ModelBase
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
        public string ResourceType { get; set; }

        [StringLength(20)]
        public string ResourceId { get; set; }

        [StringLength(20)]
        public string ResourceNO { get; set; }

        [StringLength(255)]
        public string ResourceName { get; set; }

        [StringLength(255)]
        public string GuiGeXH { get; set; }

        [StringLength(80)]
        public string Unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ResourceDingePrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ResourceUnitPrice { get; set; }

        [StringLength(255)]
        public string ChangDi { get; set; }

        [StringLength(255)]
        public string GongHuoCS { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sl { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(50)]
        public string JgBz { get; set; }

        [StringLength(50)]
        public string ZyclBz { get; set; }

        [StringLength(50)]
        public string ZgjBz { get; set; }

        [StringLength(50)]
        public string ZcBz { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ResourceTotalPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Dej { get; set; }

        [StringLength(50)]
        public string ResourceTypeName { get; set; }
    }
}
