using System;
using System.Globalization;
using System.Linq;
using TCC.Fernando.Especificacao3.Enums;
using TCC.Fernando.Especificacao3.Nucleo;

namespace TCC.Fernando.Especificacao3.InterfaceUI
{
    public static class Leitor
    {
        public static Calculadora ObterEntradaConversaoMedida(string opcaoEntrada, 
                                                              string valorEntrada_1,
                                                              string valorEntrada_2, 
                                                              string quantidadeCasasDecimais)
        {
            return ObterCalculadora(opcaoEntrada, valorEntrada_1, valorEntrada_2, quantidadeCasasDecimais);
        }

        private static Calculadora ObterCalculadora(string opcaoEntrada, 
                                                    string valorEntrada_1, 
                                                    string valorEntrada_2,
                                                    string quantidadeCasasDecimais)
        {
            return new Calculadora(ConverterEnumComTratamento(opcaoEntrada), 
                                   ConveterDoubleComtratamento(valorEntrada_1),
                                   ConveterDoubleComtratamento(valorEntrada_2),
                                   ConverterIntComTratamento(quantidadeCasasDecimais));
        }

        private static double ConveterDoubleComtratamento(string opcaoEntrada)
        {
            bool entradaValida = double.TryParse(opcaoEntrada, NumberStyles.Float, CultureInfo.InvariantCulture, out double valor);

            if (!entradaValida || valor < 0)
            {
                string erro = $"Entrada invalida, {opcaoEntrada} nao e aceitavel";
                throw new ArgumentException(erro);
            }

            return valor;
        }

        private static int ConverterIntComTratamento(string quantidadeCasasDecimais)
        {
            bool entradaValida = int.TryParse(quantidadeCasasDecimais, out int valor);

            if (!entradaValida)
            {
                string erro = $"Entrada invalida, {quantidadeCasasDecimais}";
                throw new ArgumentException(erro);
            }

            return valor;
        }

        private static Operacao ConverterEnumComTratamento(string opcaoEntrada)
        {
            bool entradaValida = char.TryParse(opcaoEntrada, out char valor);

            var tiposMedidasValidos = Enum.GetValues(typeof(Operacao)).Cast<Operacao>().Select(tipo => tipo);

            if (!entradaValida || !tiposMedidasValidos.Contains((Operacao) valor))
            {
                string textoRangeValorValidos = string.Join(", ", tiposMedidasValidos.Select(medidad => medidad.ToString()));
                string erro = $"Entrada invalida, {opcaoEntrada} nao está no range {textoRangeValorValidos}";
                throw new ArgumentException(erro);
            }

            return (Operacao) valor;
        }
    }
}
