namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_Dlxm : ModelBase
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

        [Column(TypeName = "numeric")]
        public decimal? Sl { get; set; }

        [StringLength(500)]
        public string Mc_TZ { get; set; }

        [StringLength(80)]
        public string Dw_TZ { get; set; }

        [StringLength(2)]
        public string DuoQueX { get; set; }

        [StringLength(50)]
        public string IS_Accord_TZ { get; set; }

        [StringLength(50)]
        public string Is_Error_TZ { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Dj { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Hj { get; set; }

        [StringLength(20)]
        public string Xh { get; set; }

        [StringLength(255)]
        public string Mc { get; set; }

        [StringLength(80)]
        public string Dw { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        public int? Xmlb { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sl_TZ { get; set; }
    }
}
