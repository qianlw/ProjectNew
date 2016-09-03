namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_ZbgyclMx : ModelBase
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

        [Column(TypeName = "numeric")]
        public decimal? Ysj { get; set; }

        [StringLength(50)]
        public string Bz { get; set; }

        [StringLength(50)]
        public string DanWeiGCName { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string Xh { get; set; }

        [StringLength(50)]
        public string Clbm { get; set; }

        [StringLength(50)]
        public string Mc { get; set; }

        [StringLength(50)]
        public string Xhgg { get; set; }

        [StringLength(50)]
        public string Dw { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Gyj { get; set; }

        [StringLength(50)]
        public string Gytj { get; set; }

        [StringLength(50)]
        public string PFDValue { get; set; }

        [StringLength(50)]
        public string PBBF { get; set; }

        [StringLength(50)]
        public string FeiBiaoJieDianName { get; set; }

        [StringLength(50)]
        public string PFDName { get; set; }
    }
}
