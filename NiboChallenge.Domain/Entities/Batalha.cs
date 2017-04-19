using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
   public class Batalha: EntityBase
    {
        public Guid PrimeiroJogadorId { get; set;}
        public Jogador PrimeiroJogador { get; set; }
        public Guid SegundoJogadorId { get; set; }
        public Jogador SegundoJogador { get; set; }
        public Guid VencedorId { get; set; }
        public Jogador Vencedor { get; set; }
    }
}
