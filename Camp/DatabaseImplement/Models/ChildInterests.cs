namespace DatabaseImplement.Models
{
    public class ChildInterests
    {
        public int id { get; set; }
        public int ChildId { get; set; }
        public int InterestId { get; set; }        
        public virtual Child children { get; set; }
        public virtual Interest interest { get; set; }
    }
}
