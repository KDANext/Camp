using BusinessLogic.Enums;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class CounsellorBindingModel
    {
        public int? id { get; set; }
        public string FIO { get; set; }
        public int? GroupId { get; set; }         
        public List<Interests> interests { get; set; }
        public List<ExperienceBindingModel> experience { get; set; }

    }
}
