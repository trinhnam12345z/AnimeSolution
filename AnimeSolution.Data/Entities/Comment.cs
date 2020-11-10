using AnimeSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int AnimeID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }
        public Status Status { get; set; }
    }
}
