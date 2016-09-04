namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PingBiaoPeople : ModelBase
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
        public string Name { get; set; }

        [StringLength(50)]
        public string UnitName { get; set; }

        [StringLength(50)]
        public string LianXiTel { get; set; }

        [StringLength(50)]
        public string IDCard { get; set; }

        [StringLength(50)]
        public string ZhiWu { get; set; }

        [StringLength(50)]
        public string YuDingGuid { get; set; }

        [StringLength(50)]
        public string DJR_Code { get; set; }

        [StringLength(50)]
        public string DJR_Name { get; set; }

        [StringLength(50)]
        public string DJR_Date { get; set; }

        [StringLength(50)]
        public string PepoleType { get; set; }
    }
}
