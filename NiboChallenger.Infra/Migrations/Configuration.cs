using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;

namespace NiboChallenger.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.NiboChallengerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            //Set to false if do not wish data loss during automatic migration
            AutomaticMigrationDataLossAllowed = true;
        }
        protected override void Seed(Context.NiboChallengerContext context)
        {
            // Useful to initialize insert of data in the databases



            try
            {

                //fills the table habilidades
                var SkillDbSet = context.Set<Skill>();
                SkillDbSet.Add(new Skill()
                {
                    Id = Guid.NewGuid(),
                    Name = "Onda Sônica",
                    Detail = "Projeta  uma onda de som para localizar seus inimigos, causando Dano Físico ao primeiro que encontrar. Caso a Onda Sônica acerte, Lee Sin poderá lançar o Ataque Ressonante pelos próximos 3 segundos",

                });

                SkillDbSet.Add(new Skill()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ataque Ressonante",
                    Detail = "Avança até o inimigo, causando Dano Físico mais 8% de sua Vida perdida.",

                });

                SkillDbSet.Add(new Skill()
                {
                    Id = Guid.NewGuid(),
                    Name = "Contra-Ataque",
                    Detail = "Adota uma postura defensiva por até 2 segundos, desviando de todos os ataques básicos recebidos.",

                });
                SkillDbSet.Add(new Skill()
                {
                    Id = Guid.NewGuid(),
                    Name = "Voadora",
                    Detail = "Apenas um chute de voadora.",

                });
                SkillDbSet.Add(new Skill()
                {
                    Id = Guid.NewGuid(),
                    Name = "Explosão sinistra",
                    Detail = "Explode tudo.",

                });

                //fills the table ClasseCampeao
                var ContenderCategoryDbSet = context.Set<ContenderCategory>();

                ContenderCategoryDbSet.Add(new ContenderCategory
                {
                    Id = Guid.NewGuid(),
                    Name = "Assassino"
                });
                ContenderCategoryDbSet.Add(new ContenderCategory
                {
                    Id = Guid.NewGuid(),
                    Name = "Lutador"
                });
                ContenderCategoryDbSet.Add(new ContenderCategory
                {
                    Id = Guid.NewGuid(),
                    Name = "Mago"
                });
                ContenderCategoryDbSet.Add(new ContenderCategory
                {
                    Id = Guid.NewGuid(),
                    Name = "Suporte(The best)"
                });
                ContenderCategoryDbSet.Add(new ContenderCategory
                {
                    Id = Guid.NewGuid(),
                    Name = "Tanque(Atenção somente para brabos)"
                });
                ContenderCategoryDbSet.Add(new ContenderCategory
                {
                    Id = Guid.NewGuid(),
                    Name = "Atirador"
                });


                context.SaveChanges();
            }
            catch (Exception)
            {


            }

        }
    }
}
