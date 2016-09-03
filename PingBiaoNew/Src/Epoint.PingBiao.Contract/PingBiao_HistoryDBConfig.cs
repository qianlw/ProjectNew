namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_HistoryDBConfig
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
        public string SysGuid { get; set; }

        [StringLength(50)]
        public string HistoryDB_Name { get; set; }

        [StringLength(300)]
        public string HistoryDB_ConnString { get; set; }

        public int? IsNowUse { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        [StringLength(1)]
        public string DBType { get; set; }
    }
}
