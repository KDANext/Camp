using BusinessLogic.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string interest { get; set; }
        public virtual List<ChildInterests> childInterests { get; set; }
        public virtual List<CounsellorInterests> counsellorInterests { get; set; }
    }
}
