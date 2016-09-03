namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZhiXun : ModelBase
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
        public string BiaoDuanGuid { get; set; }

        [StringLength(50)]
        public string BiaoDuanNo { get; set; }

        [StringLength(500)]
        public string BiaoDuanName { get; set; }

        [StringLength(50)]
        public string SenderCode { get; set; }

        [StringLength(50)]
        public string SenderName { get; set; }

        public DateTime? SenderDate { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(4000)]
        public string HuiDaContent { get; set; }

        [StringLength(50)]
        public string HuiDaCoder { get; set; }

        [StringLength(50)]
        public string HuiDaName { get; set; }

        public DateTime? HuiDaDate { get; set; }

        [StringLength(50)]
        public string ZhiZunNo { get; set; }

        [StringLength(500)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string HuiDaLimit { get; set; }

        [Column(TypeName = "ntext")]
        public string DS { get; set; }

        [StringLength(50)]
        public string Cert { get; set; }

        [StringLength(500)]
        public string ZhiYiTitle { get; set; }

        [StringLength(3000)]
        public string ZhiYiContent { get; set; }

        [StringLength(3000)]
        public string PBWYHHeaderContent { get; set; }

        public DateTime? HuiDaLimitTime { get; set; }

        [StringLength(3000)]
        public string PBWYHContent { get; set; }

        [StringLength(10)]
        public string Ispass { get; set; }

        [StringLength(3000)]
        public string HuiFuYQ { get; set; }

        [StringLength(50)]
        public string AttachConnStr { get; set; }

        [StringLength(1)]
        public string IsQZ { get; set; }

        [StringLength(50)]
        public string DaFuAttachGuid { get; set; }

        [StringLength(2000)]
        public string FilePath { get; set; }
    }
}
