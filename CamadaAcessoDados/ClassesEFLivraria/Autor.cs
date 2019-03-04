using System;
using System.Collections.Generic;
using System.Text;

namespace CamadaAcessoDados.ClassesEFLivraria
{
    class Autor
    {
        public int AutorId{get; set;}
        public string Nome { get; set; }

        public ICollection<LivroAutor> LivrosLink { get; set; }
    }
}
