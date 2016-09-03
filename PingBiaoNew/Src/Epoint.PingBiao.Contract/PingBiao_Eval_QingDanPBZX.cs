namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_QingDanPBZX
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
        public string QingDanNO { get; set; }

        [StringLength(255)]
        public string QingDanName { get; set; }

        [StringLength(50)]
        public string ISZhiXun { get; set; }

        [StringLength(50)]
        public string ISHeLi { get; set; }

        [StringLength(2000)]
        public string ZhiXunYY { get; set; }

        [StringLength(2000)]
        public string TouBiaoRCQ { get; set; }

        [StringLength(50)]
        public string ZhiXunRGuid { get; set; }

        [StringLength(50)]
        public string ZhiXunR { get; set; }
    }
}
