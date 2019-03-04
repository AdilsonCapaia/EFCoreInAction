using System;
using System.Collections.Generic;
using System.Text;

namespace CamadaAcessoDados.ClassesEFLivraria
{
    class LivroAutor
    {
        public int LivroId { get; set; }
        public int AutorId { get; set; }
        public byte order { get; set; }

        public Livro Livro { get; set; }
        public Autor Autor { get; set; }
    }
}
