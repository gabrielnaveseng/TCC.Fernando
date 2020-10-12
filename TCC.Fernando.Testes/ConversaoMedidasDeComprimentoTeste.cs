﻿using TCC.Fernando.Especificacao1.Fabrica;
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
    }
}