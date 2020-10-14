using System;
using TCC.Fernando.Especificacao3.Enums;

namespace TCC.Fernando.Especificacao3.Nucleo
{
    public class Calculadora
    {
        public readonly Operacao Operador;
        public readonly double Valor1;
        public readonly double Valor2;
        public readonly int QuantidadeCasasDecimais;

        public Calculadora(Operacao operador, double valor1, double valor2, int quantidadeCasasDecimais)
        {
            Operador = operador;
            Valor1 = valor1;
            Valor2 = valor2;
            QuantidadeCasasDecimais = quantidadeCasasDecimais;
        }

        internal double Calcular()
        {
            switch (Operador)
            {
                case Operacao.Adicao:
                    return Math.Round(Valor1 + Valor2, QuantidadeCasasDecimais);
                case Operacao.Divisao:
                    if (Valor2 != 0)
                    {
                        return Math.Round(Valor1 / Valor2, QuantidadeCasasDecimais);
                    }
                    else
                    {
                        throw new DivideByZeroException("Divisão por 0 não permitida!");
                    }
                case Operacao.Multiplicacao:
                    return Math.Round(Valor1 * Valor2, QuantidadeCasasDecimais); ;
                case Operacao.Subtracao:
                    return Math.Round(Valor1 - Valor2, QuantidadeCasasDecimais); ;
                default:
                    throw new NotImplementedException("Operacao não implementada");
            }
        }
    }
}
