namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_QuFeiTZ
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

        [StringLength(255)]
        public string DanWeiGCNo { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string OrderNum { get; set; }

        [StringLength(255)]
        public string FeiYongName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuFeiJS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuFeiFL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZhengFL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TiaoZhengPrice { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [StringLength(10)]
        public string IsGuiFeiZX { get; set; }

        [StringLength(10)]
        public string IsShuiJin { get; set; }

        [StringLength(10)]
        public string IsXCAQ { get; set; }

        [StringLength(50)]
        public string Fyxlb { get; set; }
    }
}
