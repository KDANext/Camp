using BusinessLogic.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Interest
    {
        public int id { get; set; }
        public Interests interest { get; set; }

        [ForeignKey("InterestId")]
        public virtual List<ChildInterests> childInterests { get; set; }

        [ForeignKey("InterestId")]
        public virtual List<CounsellorInterests> counsellorInterests { get; set; }
    }
}
