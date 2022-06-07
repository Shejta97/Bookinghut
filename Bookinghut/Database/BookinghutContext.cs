using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookinghut.Database
{
    public partial class BookinghutContext : DbContext
    {
        public BookinghutContext(DbContextOptions<BookinghutContext> options)
         : base(options)
        {
        }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<User> User { get; set; }

        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<UserEvent> UserEvent { get; set; }
        public virtual DbSet<CurrentEvent> CurrentEvent { get; set; }
        public virtual DbSet<Venue> Venue { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
     .HasOne(e => e.CurrentEvent)
     .WithOne(c => c.Event).HasForeignKey<CurrentEvent>(b => b.EventID);
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}