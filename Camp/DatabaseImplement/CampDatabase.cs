using DatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;


namespace DatabaseImplement
{
    public class CampDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=CampDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Child> Children { set; get; }
        public virtual DbSet<ChildInterests> ChildInterests { set; get; }
        public virtual DbSet<Counsellor> Counsellors { set; get; }
        public virtual DbSet<CounsellorInterests> CounsellorInterests { set; get; }        
        public virtual DbSet<Experience> Experience { set; get; }
        public virtual DbSet<Group> Groups { set; get; }
        public virtual DbSet<Interest> Interests { set; get; }
    }
}

