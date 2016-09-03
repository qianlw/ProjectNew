namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_BiaoJue : ModelBase
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
        public string ItemGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(500)]
        public string BiaoJueTitle { get; set; }

        [StringLength(4000)]
        public string BiaoJueContent { get; set; }

        [StringLength(50)]
        public string SendUserGuid { get; set; }

        [StringLength(50)]
        public string SendUserName { get; set; }

        public DateTime? SendDate { get; set; }

        [StringLength(50)]
        public string LastResult { get; set; }

        [StringLength(500)]
        public string BiaoDuanName { get; set; }

        [StringLength(3000)]
        public string BiaoJueYJ { get; set; }
    }
}
