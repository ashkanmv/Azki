using azki.Model;
using Microsoft.EntityFrameworkCore;

namespace azki.Persistence
{
    public class AzkiContext : DbContext
    {
        public AzkiContext(DbContextOptions<AzkiContext> options) : base(options) { }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<InstrumentOption> InstrumentColors { get; set; }
        public DbSet<Discount> Discounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instrument>().HasMany(i => i.InstrumentOptions).WithMany(i => i.Instruments);
            modelBuilder.Entity<Instrument>().Property(i => i.FullTitle).HasMaxLength(200);
            modelBuilder.Entity<Instrument>().Property(i => i.Description).HasMaxLength(1000);
            modelBuilder.Entity<Instrument>().Property(i => i.Result).HasMaxLength(1000);
            modelBuilder.Entity<Instrument>().Property(i => i.Title).HasMaxLength(200);
            modelBuilder.Entity<Instrument>().Property(i => i.SvgUrl).HasMaxLength(200);

            modelBuilder.Entity<InstrumentOption>().Property(i => i.Title).HasMaxLength(100);
            modelBuilder.Entity<InstrumentOption>().Property(i => i.Description).HasMaxLength(1000);
            
            modelBuilder.Entity<Discount>().Property(i => i.Code).HasMaxLength(100);
            modelBuilder.Entity<Discount>().Property(i => i.Title).HasMaxLength(100);
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
