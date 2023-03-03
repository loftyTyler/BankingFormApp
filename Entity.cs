using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BankingFormApp
{
    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }

        public virtual DbSet<databaseTesting> databaseTestings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<databaseTesting>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<databaseTesting>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<databaseTesting>()
                .Property(e => e.fullName)
                .IsUnicode(false);

            modelBuilder.Entity<databaseTesting>()
                .Property(e => e.accountBalance)
                .HasPrecision(19, 4);
        }
    }
}
