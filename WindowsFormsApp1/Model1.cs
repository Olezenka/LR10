using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<PriceList> PriceList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceList>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PriceList>()
                .Property(e => e.Color)
                .IsUnicode(false);
        }
    }
}
