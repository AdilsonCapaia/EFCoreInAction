using System;
using System.Collections.Generic;
using System.Text;

namespace CamadaAcessoDados.ClassesEFLivraria
{
    class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public decimal Preco { get; set; }

        public string UrlImagem { get; set; }
        public bool leveSupressao { get; set; }

        public Promocao Promocao { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }
        public ICollection<LivroAutor> AutoresLink { get; set; }
    }
}
