
using System;
using System.Collections.Generic;

namespace SPA.BusinessModels
{
    public class Movie 
    {
        public int projectId { get; set; }
        public string title { get; set; }
        public int releaseYear { get; set; }
        public string gerne { get; set; }
        public bool greenlit { get; set; }
        public string aspectRatio { get; set; }
    }
}