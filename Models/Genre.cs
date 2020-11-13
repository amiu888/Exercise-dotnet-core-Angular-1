using System;
using System.Collections.Generic;

#nullable disable

namespace SPA.Models
{
    public partial class Genre
    {
        public int GenreId { get; set; }
        public string Genre1{ get; set; }
        public string GenreShortName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
