using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Zoolandia.Model.Animals;
using Zoolandia.Models;
using Zoolandia.Model.Animals.Habitats;
using Zoolandia.Taxonomy.Species;

namespace Zoolandia
{
    public class ZoolandiaDbContext : DbContext
    {
        //public DbSet<Habitat> Habitat { get; set; }
        public DbSet<Animal> Animal { get; set; }
        //public DbSet<Species> Species { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // this incorporates the tables you need
            //can configure more than this but could do everything you want in LINQ
            //UserManagerFactory
            //    = () => new UserManager<IdentityUser>(new UserStore<IdentityUser>(new modelBuilder()));

            //modelBuilder.Entity<Habitat>()
            //    .ToTable("Habitat")
            //    .HasKey(h => h.IdHabitat);

            modelBuilder.Entity<Animal>()
                .ToTable("Animal")
                .HasKey(a => a.IdAnimal);

            //modelBuilder.Entity<Species>()
            //    .ToTable("Species")
            //    .HasKey(s => s.IdSpecies);
        }


    }
}
