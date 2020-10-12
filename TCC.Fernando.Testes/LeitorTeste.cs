using System;
using TCC.Fernando.Especificacao1.InterfaceUI;
using Xunit;

namespace TCC.Fernando.Testes
{
    public class LeitorTeste
    {
        [Theory]
        [InlineData("","","")]
        public void LeituraIntInvalida(string opcaoEntrada, string valorEntrada, string opcaoSaida)
        {
            _ = Assert.Throws<ArgumentException>(() => Leitor.ObterEntradaConversaoMedida(opcaoEntrada, valorEntrada, opcaoSaida));
        }

        [Theory]
        [InlineData("1", "100", "1")]
        [InlineData("2", "100", "2")]
        public void LeituraIntValida(string opcaoEntrada, string valorEntrada, string opcaoSaida)
        {
            var entrada = Leitor.ObterEntradaConversaoMedida(opcaoEntrada, valorEntrada, opcaoSaida);

            Assert.True(entrada.Valor == Convert.ToDouble(valorEntrada)
                && (int)entrada.De == Convert.ToInt32(opcaoEntrada) 
                && (int)entrada.Para == Convert.ToInt32(opcaoSaida));
        }
    }
}
