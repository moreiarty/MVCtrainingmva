using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCtrainingmva.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public Album Album { get; set; }
        public string Contents { get; set; }
        public string ReviewerEmail { get; set; }
    }
}
