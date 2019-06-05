using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CopperMouseNetVue.Model
{
    public partial class CopperMouseInkContext : DbContext
    {
        public CopperMouseInkContext()
        {
        }

        public CopperMouseInkContext(DbContextOptions<CopperMouseInkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Table> Table { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:coppermouseinkdbserver.database.windows.net,1433;Initial Catalog=CopperMouseInk;Persist Security Info=False;User ID=CopperMouseInk;Password=Jessie9417;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Table>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UserCart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
        public void AddEntity()
        {
            Console.WriteLine("blah");
        }
    }
}
