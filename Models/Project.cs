using System;
using System.Collections.Generic;

#nullable disable

namespace SPA.Models
{
    public partial class Project
    {
        public Project()
        {
            Productions = new HashSet<Production>();
        }

        public int ProjectId { get; set; }
        public int? ReleaseYear { get; set; }
        public string ProductionNumber { get; set; }
        public string DevelopmentNumber { get; set; }
        public string ScriptContractuallyDue { get; set; }
        public string ScriptExpected { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Title { get; set; }
        public int? SgenNo { get; set; }

        public virtual ICollection<Production> Productions { get; set; }
    }
}
