using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Competidor : EntityWithName
    {
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public Guid ClasseCampeaoId { get; set; }
        public ClasseCampeao ClasseCampeao { get; set; }
        public Guid PrimeiraHabilidadeId { get; set; }
        public Habilidade PrimeiraHabilidade { get; set; }
        public Guid SegundaHabilidadeId { get; set; }
        public Habilidade SegundaHabilidade { get; set; }
    }
}
