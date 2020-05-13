using BusinessLogic.Enums;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
    class Child
    {
        public int? id { get; set; }
        public int FIOid { get; set; }
        public int GroupId { get; set; }
        public int Age { get; set; }
        public List<Interests> children { get; set; }
    }
}
