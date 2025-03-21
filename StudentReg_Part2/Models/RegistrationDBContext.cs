using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StudentReg_Part2.Models
{
    public partial class RegistrationDBContext : DbContext
    {
        public RegistrationDBContext()
            : base("name=RegistrationDBContext")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
