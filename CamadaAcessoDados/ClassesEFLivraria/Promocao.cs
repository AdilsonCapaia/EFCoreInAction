using System;
using System.Collections.Generic;
using System.Text;

namespace CamadaAcessoDados.ClassesEFLivraria
{
    class Promocao
    {
        public int PromocaoId { get; set; }
        public decimal NovoPreco { get; set; }
        public string TextoPromocional { get; set; }

        public int LivroId { get; set; }
    }
}
