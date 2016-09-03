namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_Eval_GuifeiDefault : ModelBase
    {
        [StringLength(255)]
        public string GuifeiGuid { get; set; }

        [StringLength(255)]
        public string MoBanName { get; set; }

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

        [Column(TypeName = "numeric")]
        public decimal? Guifei1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei8 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei9 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei10 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei11 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei12 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei13 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei14 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei15 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei16 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei17 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei18 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei19 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei20 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei21 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Guifei22 { get; set; }
    }
}
