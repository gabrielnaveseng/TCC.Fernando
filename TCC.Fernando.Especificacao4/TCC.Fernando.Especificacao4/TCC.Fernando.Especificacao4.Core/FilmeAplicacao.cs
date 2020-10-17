using System.Collections.Generic;
using System.Linq;
using TCC.Fernando.Especificacao4.Core.Entidade;

namespace TCC.Fernando.Especificacao4.Core
{
    public class FilmeAplicacao
    {
        private static List<Filme> FilmesCadastrados;
        private static FilmeAplicacao Aplicacao;

        private FilmeAplicacao()
        {
            FilmesCadastrados = new List<Filme>();
        }

        public static FilmeAplicacao Obter()
        {
            if (Aplicacao == null)
            {
                Aplicacao = new FilmeAplicacao();
            }

            return Aplicacao;
        }

        public void Salvar(Filme filme)
        {
            if (FilmesCadastrados == null)
            {
                FilmesCadastrados = new List<Filme>();
            }

            FilmesCadastrados.Add(filme);
        }

        public IEnumerable<Filme> Filtrar(string TituloFilme, string Genero, string Estudio, int? Ano)
        {
            IEnumerable<Filme> filmesFiltrados = FilmesCadastrados;

            if (!string.IsNullOrWhiteSpace(Genero))
                filmesFiltrados = filmesFiltrados.Where(filme => filme.Genero == Genero);

            if (!string.IsNullOrWhiteSpace(TituloFilme))
                filmesFiltrados = filmesFiltrados.Where(filme => filme.TituloFilme == TituloFilme);

            if (!string.IsNullOrWhiteSpace(Estudio))
                filmesFiltrados = filmesFiltrados.Where(filme => filme.Estudio == Estudio);

            if (Ano != null)
                filmesFiltrados = filmesFiltrados.Where(filme => filme.Ano == Ano);

            return filmesFiltrados;
        }
    }
}
