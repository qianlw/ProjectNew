namespace Epoint.PingBiao.Contract
{
    using Epoint.Framework.Contract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PingBiao_QDImportErrorInfo : ModelBase
    {
        
        public int Row_ID { get; set; }

        [StringLength(255)]
        public string BiaoDuanGuid { get; set; }

        [StringLength(255)]
        public string DanWeiGuid { get; set; }

        [StringLength(255)]
        public string TableName { get; set; }

        [Column(TypeName = "text")]
        public string ErrorData { get; set; }

        [Column(TypeName = "text")]
        public string ErrorInfo { get; set; }
    }
}
