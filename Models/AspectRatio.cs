using System;
using System.Collections.Generic;

#nullable disable

namespace SPA.Models
{
    public partial class AspectRatio
    {
        public int AspectRatioId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
