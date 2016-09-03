namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PWDF
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
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string DanWeiMC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AVG_PM { get; set; }

        public int? PingWeiPM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PianLilv_PM { get; set; }

        public int? PaiMingJG { get; set; }

        [StringLength(50)]
        public string PaiMingJieGuo { get; set; }

        [StringLength(50)]
        public string PingWeiGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AVG_DF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PingWeiDF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PianLiLv_DF { get; set; }

        public int? DaFenJG { get; set; }

        [StringLength(50)]
        public string DaFenJieGuo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? JiaQuanDF { get; set; }

        [StringLength(50)]
        public string PingFenType { get; set; }

        public DateTime? MarkTime { get; set; }
    }
}
