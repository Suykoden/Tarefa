using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class BatalhaCampeao : EntityBase
    {
        public Guid Batalhaid { get; set; }
        public Batalha Batalha { get; set; }
        public Guid CampeaoPrimeiroJogadorid { get; set; }
        public Campeao CampeaoPrimeiroJogador { get; set; }
        public Guid CampeaoSegundoJogadorid { get; set; }
        public Campeao CampeaoSegundoJogador { get; set; }
        
    }

}

