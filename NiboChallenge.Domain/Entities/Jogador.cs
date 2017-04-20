using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Jogador : EntityWithName
    {
        public string Apelido { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
    }
}
