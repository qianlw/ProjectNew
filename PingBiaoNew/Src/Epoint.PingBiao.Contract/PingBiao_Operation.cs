namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Operation : ModelBase
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
        public string OpIP { get; set; }

        [StringLength(50)]
        public string OpName { get; set; }

        [StringLength(50)]
        public string OpGuid { get; set; }

        public DateTime? OpTime { get; set; }

        [StringLength(3000)]
        public string OpContent { get; set; }

        [StringLength(50)]
        public string OpType { get; set; }

        [StringLength(50)]
        public string ProjectGuid { get; set; }

        [StringLength(500)]
        public string ProjectName { get; set; }

        [StringLength(50)]
        public string ProjectBH { get; set; }
    }
}
