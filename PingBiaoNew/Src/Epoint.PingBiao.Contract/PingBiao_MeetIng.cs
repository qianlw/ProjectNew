namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_MeetIng
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

        [StringLength(2500)]
        public string confDesc { get; set; }

        [StringLength(250)]
        public string confPass { get; set; }

        [StringLength(250)]
        public string confPass2 { get; set; }

        [Column("lock")]
        [StringLength(50)]
        public string _lock { get; set; }

        [StringLength(50)]
        public string maxAttendee { get; set; }

        [StringLength(50)]
        public string MeetID { get; set; }

        public DateTime? begindate { get; set; }

        public DateTime? endDate { get; set; }

        [StringLength(2500)]
        public string MeetName { get; set; }

        [StringLength(50)]
        public string begintime { get; set; }

        [StringLength(50)]
        public string endtime { get; set; }

        [StringLength(50)]
        public string isopen { get; set; }

        [StringLength(50)]
        public string XiaQuCode { get; set; }
    }
}
