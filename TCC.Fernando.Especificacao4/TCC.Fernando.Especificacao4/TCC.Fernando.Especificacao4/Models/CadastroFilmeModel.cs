using System.Collections.Generic;
using System.Linq;
using TCC.Fernando.Especificacao4.Core.Entidade;

namespace TCC.Fernando.Especificacao4.Models
{
    public class CadastroFilmeModel
    {
        public CadastroFilmeModel(IEnumerable<Filme> filmes, string tituloFilme, string genero, string estudio, int? ano)
        {
            Filmes = filmes.Select(filme => new FilmeModel()
            {
                Ano = filme.Ano,
                Estudio = filme.Estudio,
                Genero = filme.Genero,
                TituloFilme = filme.TituloFilme
            });

            Filtro = new FilmeModel()
            {
                Ano = ano,
                Estudio = estudio,
                TituloFilme = tituloFilme,
                Genero = genero
            };
        }

        public FilmeModel Filtro { get; set; }
        public IEnumerable<FilmeModel> Filmes { get; set; }
    }

    public class FilmeModel
    {
        public string TituloFilme { get; set; }
        public string Genero { get; set; }
        public string Estudio { get; set; }
        public int? Ano { get; set; }
    }
}
