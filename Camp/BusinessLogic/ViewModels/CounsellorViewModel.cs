using BusinessLogic.Enums;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
    public class CounsellorViewModel
    {
        public int? Id { get; set; }
        public string FIO { get; set; }
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public Dictionary<int, string> CounsellorInterests { get; set; }
        public Dictionary<int, (int, int, int)> CounsellorExperience { get; set; }
    }
}
