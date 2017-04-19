using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class JogadorCampeao : EntityBase
    {
        public Guid CampeaoId { get; set; }
        public Campeao Campeao { get; set; }
        public Guid JogadorId { get; set; }
        public Jogador Jogador { get; set; }
    }
}
