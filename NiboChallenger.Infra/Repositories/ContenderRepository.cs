using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Entities;
using NiboChallenge.Domain.Interfaces.Repositories;
using NiboChallenger.Infra.Context;
using NiboChallenger.Application.DTO;

namespace NiboChallenger.Infra.Repositories
{
    public class ContenderRepository : RepositoryBase<Contender>, IContenderRepository
    {
        protected NiboChallengerContext Db = new NiboChallengerContext();


        public IEnumerable<ContenderDto> GetContenders()
        {

            var ConterderList = (from c in Db.Contenders
                                     join cc in Db.ContenderCategories on c.ContenderCategoryId equals cc.Id
                                     select new ContenderDto()
                                     {
                                         Victory =c.Victory
                                        


                                     });


            return ConterderList.ToList();



        }

     
    }
}
