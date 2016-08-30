using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Epoint.Framework.Contract;

namespace Epoint.Crm.Contract
{
    [Table("Project")]
    public class Project : ModelBase
    {
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<VisitRecord> VisitRecords { get; set; }
    }
}
