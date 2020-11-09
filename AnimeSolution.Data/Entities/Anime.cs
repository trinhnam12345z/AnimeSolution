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
        public int CategoryID { get; set; }
        public int Viewed { get; set; }
        public string Status { get; set; }
    }
}
