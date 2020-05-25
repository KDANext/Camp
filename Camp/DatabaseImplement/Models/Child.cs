using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Child
    {
        public int id { get; set; }
        public int? GroupId { get; set; }

        [Required]
        public string FIO { get; set; }
        public int Age { get; set; }

        [ForeignKey("ChildId")]
        public virtual List<ChildInterests> interests { get; set; }
        public virtual Group group { get; set; }
    }
}
