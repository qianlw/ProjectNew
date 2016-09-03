namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Menu_Category : ModelBase
    {
        [StringLength(50)]
        public string IsOpen { get; set; }

        [StringLength(50)]
        public string UnitType { get; set; }

        [StringLength(50)]
        public string CategoryNum { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(500)]
        public string HomePageUrl { get; set; }

        [StringLength(50)]
        public string IsAccountAdmin { get; set; }

        public int? OrderNum { get; set; }

        [StringLength(100)]
        public string BigIconAddress { get; set; }

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
        public string SmallIconAddress { get; set; }

        [StringLength(1)]
        public string UserType_G { get; set; }

        [StringLength(50)]
        public string UserType_K { get; set; }

        [StringLength(1)]
        public string UserType_EP { get; set; }

        [StringLength(1)]
        public string UserType_TP { get; set; }

        [StringLength(1)]
        public string UserType_M { get; set; }

        [StringLength(50)]
        public string SysXiaQuCode { get; set; }

        [StringLength(50)]
        public string XiaQuOperType { get; set; }

        [StringLength(1)]
        public string UserType_J { get; set; }

        [StringLength(50)]
        public string domain { get; set; }

        [StringLength(50)]
        public string ReleasePBBF { get; set; }

        [StringLength(50)]
        public string UserType_MP { get; set; }

        [StringLength(50)]
        public string PBBF { get; set; }

        
        public int Row_ID { get; set; }

        [StringLength(2000)]
        public string Note { get; set; }

        [StringLength(50)]
        public string userType_GzryBack1 { get; set; }

        [StringLength(50)]
        public string userType_GzryBack2 { get; set; }

        [StringLength(50)]
        public string userType_GzryBack3 { get; set; }

        [StringLength(50)]
        public string userType_Back1 { get; set; }

        [StringLength(50)]
        public string userType_Back2 { get; set; }

        [StringLength(50)]
        public string userType_Back3 { get; set; }

        [StringLength(50)]
        public string HelpID { get; set; }

        [StringLength(50)]
        public string IsDiv { get; set; }
    }
}
