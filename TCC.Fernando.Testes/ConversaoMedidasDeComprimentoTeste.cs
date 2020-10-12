using System;
using TCC.Fernando.Especificacao1.Fabrica;
using TCC.Fernando.Especificacao1.Fronteira;
using TCC.Fernando.Especificacao1.Fronteira.Conversores.ConversorMedidas;
using TCC.Fernando.Especificacao1.Fronteira.Enums;
using Xunit;

namespace TCC.Fernando.Testes
{
    public class ConversaoMedidasComprimentoTeste
    {
        [Theory]
        [InlineData(TipoMedida.Centimetro, TipoMedida.Metro, 100)]
        [InlineData(TipoMedida.Metro, TipoMedida.Km, 1_000)]
        [InlineData(TipoMedida.Milimetro, TipoMedida.Centimetro, 10)]
        [InlineData(TipoMedida.Milimetro, TipoMedida.Km, 1_000_000)]
        [InlineData(TipoMedida.Km, TipoMedida.Metro, 0.001)]
        [InlineData(TipoMedida.Km, TipoMedida.Centimetro, 0.00001)]
        public void ConverterMedida(TipoMedida de, TipoMedida para, double valor)
        {
            IConversor conversor = FabricaDeConversor.ObterConversor(Conversores.MedidasDeComprimento);

            var entradaConversao = new ConversorMedidasDeComprimentoEntrada() 
            {
                De = de,
                Para = para,
                Valor = valor
            };

            var saidaConversao = (ConversorMedidasDeComprimentoSaida) conversor.Converter(entradaConversao);

            Assert.True(saidaConversao.Valor == 1);
        }

        [Theory]
        [InlineData((TipoMedida) (-1), TipoMedida.Metro, 100)]
        [InlineData(TipoMedida.Metro, (TipoMedida)(-1), 100)]
        public void ConverterMedidaNaoImplementada(TipoMedida de, TipoMedida para, double valor)
        {
            IConversor conversor = FabricaDeConversor.ObterConversor(Conversores.MedidasDeComprimento);

            var entradaConversao = new ConversorMedidasDeComprimentoEntrada()
            {
                De = de,
                Para = para,
                Valor = valor
            };

            Assert.Throws<ArgumentException>(() => conversor.Converter(entradaConversao));
        }
    }
}
