using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Counsellor
    {
        public int Id { get; set; }
        [Required]
        public string FIO { get; set; }
        public int? GroupId { get; set; }
        public virtual List<CounsellorInterests> interests { get; set; }
        public virtual List<Experience> experience { get; set; }


    }
}
