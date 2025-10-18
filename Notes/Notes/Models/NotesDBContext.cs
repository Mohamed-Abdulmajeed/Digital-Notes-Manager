using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
    public class NotesDBContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Notes> Notes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=DESKTOP-CVPENLB\\Mohamed;Database=NotesDB;Trusted_Connection=True;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Notes>(entity =>
            {
                entity.Property(n => n.Title)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(n => n.Category)
                      .HasMaxLength(20);

                entity.Property(n => n.Color)
                      .HasMaxLength(20);

                entity.Property(n => n.Content)
                      .IsRequired();

                entity.Property(n => n.IsStar)
                      .HasDefaultValue(false);

                entity.ToTable(t =>
                      t.HasCheckConstraint("CHK_Note_DateTime", "[DateTime] >= GETDATE()"));
            });

            modelBuilder.Entity<Users>()
                .HasMany(u => u.Notes)
                .WithOne(n => n.User)
                .HasForeignKey(n => n.UserId);

            modelBuilder.Entity<Users>()
                .HasIndex(u => u.UserName)
                .IsUnique();

        }   
    }

}
