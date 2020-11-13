using System;
using System.Collections.Generic;

#nullable disable

namespace SPA.Models
{
    public partial class Production
    {
        public int ProductionId { get; set; }
        public int ProjectId { get; set; }
        public int? GenreId { get; set; }
        public string ProductionNumber { get; set; }
        public string DevelopmentNumber { get; set; }
        public string Locations { get; set; }
        public bool? Format3d { get; set; }
        public string Description3d { get; set; }
        public string ActualShootDays { get; set; }
        public int? AspectRatioId { get; set; }
        public string CodeTitle { get; set; }
        public bool? CompletedDate { get; set; }
        public bool? Greenlit { get; set; }
        public string Total { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Project Project { get; set; }
    }
}
