using BusinessLogic.Enums;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
    class Counsellor
    {
        public int? id { get; set; }
        public int FIOid { get; set; }
        public int GroupId { get; set; }       
        public List<Interests> children { get; set; }
        public List<WorkExperience> workExperience { get; set; }

    }
}
