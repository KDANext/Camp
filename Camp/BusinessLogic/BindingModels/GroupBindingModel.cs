using BusinessLogic.Enums;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class GroupBindingModel
    {
        public int? Id { get; set; }
        public int? CounselorId { get; set; }
        public string Name { get; set; }         
        public Profile Profile { get; set; }
        public Dictionary<int, string> Children { get; set; }
    }
}
