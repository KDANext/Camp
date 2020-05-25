using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement.Models
{
    public class ChildInterests
    {
        public int id { get; set; }
        public int Childid { get; set; }
        public int Interestid { get; set; }        
        public virtual Child children { get; set; }
        public virtual Interest interests { get; set; }
    }
}
