using BusinessLogic.Enums;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
    class Group
    {
        public int? id { get; set; }
        public string Name { get; set; }         
        public Profile Profile { get; set; }
        public List<Child> children { get; set; }
    }
}
