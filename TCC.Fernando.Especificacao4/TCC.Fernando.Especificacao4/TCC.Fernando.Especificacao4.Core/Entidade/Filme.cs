namespace TCC.Fernando.Especificacao4.Core.Entidade
{
    public class Filme
    {
        public Filme(string tituloFilme, string genero, string estudio, int ano)
        {
            TituloFilme = tituloFilme;
            Genero = genero;
            Estudio = estudio;
            Ano = ano;
        }

        public string TituloFilme { get; private set; }
        public string Genero { get; private set; }
        public string Estudio { get; private set; }
        public int Ano { get; private set; }
    }
}
