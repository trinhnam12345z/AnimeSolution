using AnimeSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Entities
{
    public class Contact
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public Status Status { get; set; }
}
}
