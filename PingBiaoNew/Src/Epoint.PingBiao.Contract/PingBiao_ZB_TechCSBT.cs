namespace Epoint.PingBiao.Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_ZB_TechCSBT
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

        public int? SortID { get; set; }

        [StringLength(255)]
        public string BookMarkName { get; set; }

        [StringLength(255)]
        public string FirstCol { get; set; }

        [StringLength(255)]
        public string SecondCol { get; set; }

        [StringLength(255)]
        public string ThirdCol { get; set; }

        [StringLength(255)]
        public string ForthCol { get; set; }

        [StringLength(255)]
        public string Fifthcol { get; set; }

        [StringLength(255)]
        public string SixthCol { get; set; }

        [StringLength(255)]
        public string seventhCol { get; set; }

        [StringLength(255)]
        public string eighthCol { get; set; }

        [StringLength(255)]
        public string NinthCol { get; set; }

        [StringLength(255)]
        public string tenthCol { get; set; }

        [StringLength(255)]
        public string ColField { get; set; }

        [StringLength(250)]
        public string DanWeiGcName { get; set; }
    }
}
