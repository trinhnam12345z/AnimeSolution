using AnimeSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Entities
{
    public class Anime
    {
        public int AnimeID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public string MovieLink { get; set; }
        public int CategoryID { get; set; }
        public int Rate { get; set; }
        public int Viewed { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }
        public Status Status { get; set; }
        public List<AnimeInCategory> AnimeInCategories { get; set; }
    }
}
