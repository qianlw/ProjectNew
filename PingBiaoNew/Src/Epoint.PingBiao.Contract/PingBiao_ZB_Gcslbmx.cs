namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_Gcslbmx : ModelBase
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

        [Column(TypeName = "numeric")]
        public decimal? Xcglf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Jjf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Lr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sj { get; set; }

        [StringLength(50)]
        public string Bz { get; set; }

        [StringLength(50)]
        public string Lb { get; set; }

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(50)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string Xh { get; set; }

        [StringLength(50)]
        public string Mc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Yzf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cgbgf { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Qtzjf { get; set; }
    }
}
