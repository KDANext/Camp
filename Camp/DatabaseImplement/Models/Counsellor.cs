using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Counsellor
    {
        public int id { get; set; }
        [Required]
        public string FIO { get; set; }
        public int GroupId { get; set; }

        [ForeignKey("CounsellorId")]
        public virtual List<CounsellorInterests> interests { get; set; }

        [ForeignKey("CounsellorId")]
        public virtual List<Experience> experience { get; set; }
        
    }
}
