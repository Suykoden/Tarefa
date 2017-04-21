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



           /* try
            {

                //fills the table habilidades
                var HabilidadeDbSet = context.Set<Habilidade>();
                 HabilidadeDbSet.Add(new Habilidade()
                 {
                     Id = Guid.NewGuid(),
                     Nome = "Onda Sônica",
                     Detalhe = "Projeta  uma onda de som para localizar seus inimigos, causando Dano Físico ao primeiro que encontrar. Caso a Onda Sônica acerte, Lee Sin poderá lançar o Ataque Ressonante pelos próximos 3 segundos",

                 });

                 HabilidadeDbSet.Add(new Habilidade()
                 {
                     Id = Guid.NewGuid(),
                     Nome = "Ataque Ressonante",
                     Detalhe = "Avança até o inimigo, causando Dano Físico mais 8% de sua Vida perdida.",

                 });

                 HabilidadeDbSet.Add(new Habilidade()
                 {
                     Id = Guid.NewGuid(),
                     Nome = "Contra-Ataque",
                     Detalhe = "Adota uma postura defensiva por até 2 segundos, desviando de todos os ataques básicos recebidos.",

                 });
                 HabilidadeDbSet.Add(new Habilidade()
                 {
                     Id = Guid.NewGuid(),
                     Nome = "Voadora",
                     Detalhe = "Apenas um chute de voadora.",

                 });
                 HabilidadeDbSet.Add(new Habilidade()
                 {
                     Id = Guid.NewGuid(),
                     Nome = "Explosão sinistra",
                     Detalhe = "Explode tudo.",

                 });

                //fills the table ClasseCampeao
                var ClasseCampeaoDbSet = context.Set<ClasseCampeao>();

                ClasseCampeaoDbSet.Add(new ClasseCampeao
                {
                    Id = Guid.NewGuid(),
                    Nome = "Assassino"
                });
                ClasseCampeaoDbSet.Add(new ClasseCampeao
                {
                    Id = Guid.NewGuid(),
                    Nome = "Lutador"
                });
                ClasseCampeaoDbSet.Add(new ClasseCampeao
                {
                    Id = Guid.NewGuid(),
                    Nome = "Mago"
                });
                ClasseCampeaoDbSet.Add(new ClasseCampeao
                {
                    Id = Guid.NewGuid(),
                    Nome = "Suporte(The best)"
                });
                ClasseCampeaoDbSet.Add(new ClasseCampeao
                {
                    Id = Guid.NewGuid(),
                    Nome = "Tanque(Atenção somente para brabos)"
                });
                ClasseCampeaoDbSet.Add(new ClasseCampeao
                {
                    Id = Guid.NewGuid(),
                    Nome = "Atirador"
                });




                context.SaveChanges();
            }
            catch (Exception)
            {


            }*/

        }
    }
}
