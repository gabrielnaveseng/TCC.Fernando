using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using TCC.Fernando.Especificacao1.Fronteira.Conversores.ConversorMedidas;

[assembly: InternalsVisibleTo("TCC.Fernando.Testes")]
namespace TCC.Fernando.Especificacao1.InterfaceUI
{
    public static class Leitor
    {
        public static ConversorMedidasDeComprimentoEntrada ObterEntradaConversaoMedida(string opcaoEntrada, string valorEntrada, string opcaoSaida)
        {
            return ObterConversorInterno(opcaoEntrada, valorEntrada, opcaoSaida);
        }

        private static ConversorMedidasDeComprimentoEntrada ObterConversorInterno(string opcaoEntrada, string valorEntrada, string opcaoSaida)
        {
            return new ConversorMedidasDeComprimentoEntrada()
            {
                De = ConverterIntComTratamento(opcaoEntrada),
                Para = ConverterIntComTratamento(opcaoSaida),
                Valor = ConveterDoubleComtratamento(valorEntrada)
            };
        }

        private static double ConveterDoubleComtratamento(string opcaoEntrada)
        {
            bool entradaValida = double.TryParse(opcaoEntrada, out double valor);

            if (!entradaValida || valor < 0)
            {
                string erro = $"Entrada invalida, {opcaoEntrada} nao e aceitavel";
                Console.WriteLine(erro);
                throw new ArgumentException(erro);
            }

            return valor;
        }

        private static TipoMedida ConverterIntComTratamento(string opcaoEntrada)
        {
            bool entradaValida = int.TryParse(opcaoEntrada, out int valor);

            var tiposMedidasValidos = Enum.GetValues(typeof(TipoMedida)).Cast<TipoMedida>().Select(tipo => (int)tipo);

            if (!entradaValida || !tiposMedidasValidos.Contains(valor))
            {
                string textoRangeValorValidos = string.Join(", ", tiposMedidasValidos.Select(medidad => medidad.ToString()));
                string erro = $"Entrada invalida, {opcaoEntrada} nao está no range {textoRangeValorValidos}";
                Console.WriteLine(erro);
                throw new ArgumentException(erro);
            }

            return (TipoMedida) valor;
        }
    }
}
