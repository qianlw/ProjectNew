namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_PWDFSZ : ModelBase
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

        public int? PianLi_DF_Y { get; set; }

        public int? PianLi_DF_DF_Y { get; set; }

        public int? PianLi_DF_S_L { get; set; }

        public int? PianLi_DF_DF_Z { get; set; }

        public int? PianLi_DF_C { get; set; }

        public int? PianLi_DF_DF_C { get; set; }

        [StringLength(50)]
        public string BiaoDuanGuid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PianLi_PM_C { get; set; }

        public int? PianLi_DF_X_L { get; set; }

        public int? PianLi_DF_DF_L { get; set; }

        public int? PianLi_DF_S_Z { get; set; }

        public int? PianLi_DF_X_Z { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PianLi_PM_X_Z { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PianLi_PM_S_Z { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PianLi_PM_X_L { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PianLi_PM_S_L { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PianLi_PM_Y { get; set; }

        public int? PianLi_PM_DF_C { get; set; }

        public int? PianLi_PM_DF_Z { get; set; }

        public int? PianLi_PM_DF_L { get; set; }

        public int? PianLi_PM_DF_Y { get; set; }

        public int? DeFenQZ { get; set; }

        public int? DaFenQZ { get; set; }
    }
}
