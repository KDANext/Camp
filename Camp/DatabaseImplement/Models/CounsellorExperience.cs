namespace DatabaseImplement.Models
{
    public class CounsellorExperience
    {
        public int id { get; set; }
        public int CounsellorId { get; set; }
        public int ExperienceId { get; set; }
        public virtual Counsellor counsellors { get; set; }
        public virtual Experience counsellorExperience { get; set; }
    }
}
