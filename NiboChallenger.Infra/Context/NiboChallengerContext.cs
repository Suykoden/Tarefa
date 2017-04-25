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
       
        public DbSet<ContenderCategory> ContenderCategories { get; set; }
        public DbSet<Contender> Contenders { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ContendersTeam> ContendersTeams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }

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
