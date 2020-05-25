namespace DatabaseImplement.Models
{
    public class CounsellorInterests
    {
        public int id { get; set; }
        public int Counsellorid { get; set; }
        public int Interestid { get; set; }
        public virtual Counsellor counsellors { get; set; }
        public virtual Interest interests { get; set; }
    }
}
