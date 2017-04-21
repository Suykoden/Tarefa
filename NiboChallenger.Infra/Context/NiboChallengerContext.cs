using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;

namespace NiboChallenger.Infra.Context
{
    public class NiboChallengerContext : DbContext
    {
        //Setting the name of my database
        public NiboChallengerContext() :
            base("NiboChallenger")
        {

        }
       
        public DbSet<ClasseCampeao> ClasseCampeao { get; set; }
        public DbSet<Foto> Foto { get; set; }
        public DbSet<Competidor> Competidor { get; set; }
        public DbSet<Habilidade> Habilidade { get; set; }
        public DbSet<Time> Time { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setting to define that where there's the word id becomes a primary key
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("Varchar"));
        }
    }
}
