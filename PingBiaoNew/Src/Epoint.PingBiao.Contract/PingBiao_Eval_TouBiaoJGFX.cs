namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_TouBiaoJGFX
    {
        [StringLength(50)]
        public string BelongXiaQuCode { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        public DateTime? OperateDate { get; set; }

        [Key]
        public int Row_ID { get; set; }

        [StringLength(4)]
        public string YearFlag { get; set; }

        [StringLength(50)]
        public string RowGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QingDanFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MeasureFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OtherFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GuiFei { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ShuiJin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string PaiMing { get; set; }
    }
}
