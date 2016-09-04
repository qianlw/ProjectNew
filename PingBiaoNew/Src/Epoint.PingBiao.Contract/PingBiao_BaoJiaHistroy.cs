namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_BaoJiaHistroy : ModelBase
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
        public string BJGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(50)]
        public string BJR_Code { get; set; }

        [StringLength(50)]
        public string BJR_Name { get; set; }

        [StringLength(50)]
        public string BJR_Date { get; set; }

        public int? BJNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BJTotal { get; set; }

        [StringLength(50)]
        public string IsQianZhang { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string AttachConName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FinalBaoJia { get; set; }

        [StringLength(1000)]
        public string PromiseAndIntro { get; set; }

        [StringLength(2000)]
        public string FilePath { get; set; }
    }
}
