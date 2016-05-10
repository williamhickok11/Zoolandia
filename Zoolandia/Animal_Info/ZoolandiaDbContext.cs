using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Models;
//using Zoolandia.Model.Animals;

namespace Zoolandia
{
    public class ZoolandiaDbContext : DbContext
    {
        public DbSet<Habitat> Habitat { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<HabitatType> HabitatType { get; set; }
        public DbSet<Employee> Employee { get; set; }
        //public DbSet<Species> Species { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // this incorporates the tables you need
            //can configure more than this but could do everything you want in LINQ

            modelBuilder.Entity<Habitat>()
                .ToTable("Habitat")
                .HasKey(h => h.IdHabitat);

            modelBuilder.Entity<Animal>()
                .ToTable("Animal")
                .HasKey(a => a.IdAnimal);

            modelBuilder.Entity<HabitatType>()
                .ToTable("HabitatType")
                .HasKey(ht => ht.IdHabitatType);

            modelBuilder.Entity<Employee>()
                .ToTable("Employee")
                .HasKey(e => e.IdEmployee);

            //modelBuilder.Entity<Species>()
            //    .ToTable("Species")
            //    .HasKey(s => s.IdSpecies);
        }


    }
}
