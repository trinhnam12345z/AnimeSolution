using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Entities
{
    public class AnimeInCategory
    {
        public int AnimeID { get; set; }
        public Anime Anime { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
