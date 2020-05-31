﻿using BusinessLogic.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Group
    {
        public int Id { get; set; }        
        
        [Required]     
        public string Name { get; set; }
        public Profile Profile { get; set; }

        [ForeignKey("GroupId")]
        public virtual List<Child> children { get; set; }

        [ForeignKey("GroupId")]

        public virtual Counsellor counsellor { get; set; }
    }
}
