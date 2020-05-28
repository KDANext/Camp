using BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class ChildViewModel
    {
        public int? Id { get; set; }
        public int? GroupId { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public Dictionary<int, string> ChildInterests { get; set; }
    }
}
