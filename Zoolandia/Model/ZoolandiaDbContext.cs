using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;

namespace Zoolandia
{
    class ZoolandiaDbContext : DbContext
    {

        public DbSet<Animal> Animal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // this incorporates the tables you need
            //can configure more than this but could do everything you want in LINQ
            modelBuilder.Entity<Animal>()
                .ToTable("Animal")
                .HasKey(a => a.IdAnimal);
        }


    }
}
