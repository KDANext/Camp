using BusinessLogic.Enums;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class GroupBindingModel
    {
        public int? id { get; set; }
        public int? Counsellorid { get; set; }
        public string Name { get; set; }         
        public Profile Profile { get; set; }
        public List<ChildBindingModel> children { get; set; }
    }
}
