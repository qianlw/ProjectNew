namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_DanWeiGC : ModelBase
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

        [StringLength(255)]
        public string DanWeiGCNO { get; set; }

        [StringLength(255)]
        public string DanWeiGCName { get; set; }

        [StringLength(50)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string DanWeiName { get; set; }

        [StringLength(50)]
        public string SpecialtyName { get; set; }

        [StringLength(50)]
        public string Bh { get; set; }

        [Column(TypeName = "ntext")]
        public string Gcmc { get; set; }

        [StringLength(50)]
        public string SoftName { get; set; }

        public int? RecordType { get; set; }

        [StringLength(50)]
        public string Parent_No { get; set; }

        [StringLength(50)]
        public string GCType { get; set; }

        [StringLength(255)]
        public string DogNum { get; set; }

        [StringLength(255)]
        public string MachineKey { get; set; }

        [StringLength(255)]
        public string SoftNum { get; set; }

        [StringLength(500)]
        public string Jjyj { get; set; }
    }
}
