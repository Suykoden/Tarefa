using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Repositories;
using NiboChallenger.Infra.Context;

namespace NiboChallenger.Infra.Repositories
{
    public class ContenderRepository : RepositoryBase<Contender>, IContenderRepository
    {
        protected NiboChallengerContext Db = new NiboChallengerContext();


        public IEnumerable<Contender>GetContenders()
        {

            var ConterderList = (from c in Db.Contenders
                                     join cc in Db.ContenderCategories on c.ContenderCategoryId equals cc.Id
                                     select new Contender()
                                     {
                                         Id = c.Id,
                                         Ativo = c.Ativo


                                     });


            return ConterderList.ToList();



        }
    }
}
