using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.Interfaces.Services;
using NiboChallenger.Application.Interface;

namespace NiboChallenger.Application
{

    public class AppServiceBase<Tentity> : IAppServiceBase<Tentity> where Tentity : class

    {
        private readonly IServicoBase<Tentity> _servicoBase;

        public AppServiceBase(IServicoBase<Tentity> servicoBase)
        {
            _servicoBase = servicoBase;
        }

        void IAppServiceBase<Tentity>.Add(Tentity obj)
        {
            _servicoBase.Add(obj);
        }

        IEnumerable<Tentity> IAppServiceBase<Tentity>.GetAll()
        {
            return _servicoBase.GetAll();
        }

        Tentity IAppServiceBase<Tentity>.GetById(Guid id)
        {
            return _servicoBase.GetById(id);
        }

        void IAppServiceBase<Tentity>.Remove(Tentity obj)
        {
            _servicoBase.Remove(obj);
        }

        void IAppServiceBase<Tentity>.Update(Tentity obj)
        {
            _servicoBase.Update(obj);
        }
    }
}