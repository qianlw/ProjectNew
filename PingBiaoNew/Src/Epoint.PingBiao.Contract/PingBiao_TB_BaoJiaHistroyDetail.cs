namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_TB_BaoJiaHistroyDetail : ModelBase
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
        public string BJGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string JieGou { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(100)]
        public string GeShu { get; set; }

        [StringLength(20)]
        public string DanWei { get; set; }

        [Column(TypeName = "ntext")]
        public string GuiGe { get; set; }

        [Column(TypeName = "ntext")]
        public string Remark { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalPrice { get; set; }

        [StringLength(500)]
        public string ZZShName { get; set; }

        [StringLength(500)]
        public string PinPaiChanDi { get; set; }

        [StringLength(500)]
        public string TbCanShu { get; set; }

        [StringLength(500)]
        public string ChanDi { get; set; }
    }
}
