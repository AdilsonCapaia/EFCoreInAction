using System;
using System.Collections.Generic;
using System.Text;

namespace CamadaAcessoDados.ClassesEFLivraria
{
    class Avaliacao
    {
        public int AvaliacaoId { get; set; }
        public string NomeDoVotante { get; set; }
        public int NumeroDeEstrelas { get; set; }

        public int LivroId { get; set; }
    }
}
