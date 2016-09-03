namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_HistroyOfCBS
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
        public string BiaoDuanNo { get; set; }

        [StringLength(500)]
        public string BiaoDuanName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TouBiaoTotal { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(500)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string CBR_Code { get; set; }

        [StringLength(50)]
        public string CBR_Name { get; set; }

        public DateTime? CBR_Date { get; set; }
    }
}
