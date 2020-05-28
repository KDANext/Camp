﻿namespace DatabaseImplement.Models
{
    public class CounsellorInterests
    {
        public int id { get; set; }
        public int CounsellorId { get; set; }
        public int InterestId { get; set; }
        public virtual Counsellor counsellors { get; set; }
        public virtual Interest counsellorInterests { get; set; }
    }
}
