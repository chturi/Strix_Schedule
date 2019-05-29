namespace Strix_Schedule
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ResourceEventContext : DbContext
    {
        public ResourceEventContext()
            : base("name=ResourceEventContext")
        {
        }

        
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);
        }
    }
}
