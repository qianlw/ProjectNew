namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PBFlowSet : ModelBase
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
        public string PBBF { get; set; }

        [StringLength(50)]
        public string UserType { get; set; }

        [StringLength(50)]
        public string StepName { get; set; }

        [StringLength(250)]
        public string ConectionAddress { get; set; }

        [StringLength(250)]
        public string PicAddress { get; set; }

        [StringLength(50)]
        public string LimitCondition { get; set; }

        [StringLength(50)]
        public string StartCode { get; set; }

        [StringLength(50)]
        public string StepCode { get; set; }

        [StringLength(50)]
        public string Sequence { get; set; }

        [StringLength(50)]
        public string EndCode { get; set; }

        [StringLength(50)]
        public string PFDType { get; set; }
    }
}
