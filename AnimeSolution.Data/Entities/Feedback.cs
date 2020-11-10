using AnimeSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeSolution.Data.Entities
{
    public class Feedback
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
    }
}
