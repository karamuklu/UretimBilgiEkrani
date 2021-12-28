using BG_Entities.Entities;
using System.Data.Entity;

namespace BG_Entities
{
    public class BGContext : DbContext
    {
        public DbSet<MEKANIK_CIZIMLER_MKA> MEKANIK_CIZIMLER_MKA { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MEKANIK_CIZIMLER_MKA>().ToTable("MEKANIK_CIZIMLER_MKA");
        }
    }
}