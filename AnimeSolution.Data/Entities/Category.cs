using AnimeSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string NameCategory { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Status Status { get; set; }
        public int? ParentID { get; set; }
        public int DisplayOrder { get; set; }
    }
}
