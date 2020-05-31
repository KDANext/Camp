using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseImplement.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public int CounsellorId { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public int Years { get; set; }
        public virtual Counsellor counsellor { get; set; }

        
    }
}
