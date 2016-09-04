namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_DiYuCBJPS : ModelBase
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
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string ZhuanYeBH { get; set; }

        [StringLength(255)]
        public string ZhuanYeMC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cost_TouBiao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cost_BiaoDi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ChengBenZ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RenGongDJ { get; set; }

        [StringLength(255)]
        public string BeiZhu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvgPer { get; set; }

        [StringLength(50)]
        public string IsDyHLZ { get; set; }

        [StringLength(50)]
        public string IsDyCBZ { get; set; }

        [StringLength(50)]
        public string FeiYongMC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cost_Avg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HeLiZ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BdPer { get; set; }
    }
}
