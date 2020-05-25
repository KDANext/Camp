using BusinessLogic.Enums;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class ChildBindingModel
    {
        public int? id { get; set; }
        public int? GroupId { get; set; }
        public string FIO { get; set; }        
        public int Age { get; set; }
        public List<Interests> interests { get; set; }
    }
}
