namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_ClZgBt : ModelBase
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
        public string Xh { get; set; }

        [StringLength(50)]
        public string Mc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Je { get; set; }

        public int? Lb { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }
    }
}
