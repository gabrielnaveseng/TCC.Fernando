using System;
using System.Collections.Generic;
using System.Linq;
using TCC.Fernando.Especificacao1.Fronteira;
using TCC.Fernando.Especificacao1.Fronteira.Conversores.ConversorMedidas;

namespace TCC.Fernando.Especificacao1.Nucleo.ConversorMedidas
{
    public class ConversorMedidasDeComprimento : IConversor
    {
        public IElementoConvertido Converter(IElementoEntradaConversao entradaConversao)
        {
            ConversorMedidasDeComprimentoEntrada entradaConvertida = ValidarEObterEntrada(entradaConversao);

            string descricao = ObterDescricaoConversao(entradaConvertida);
            var valor = entradaConvertida.Valor * Math.Pow(10, entradaConvertida.De - entradaConvertida.Para);
            return new ConversorMedidasDeComprimentoSaida(valor, descricao);
        }

        private static ConversorMedidasDeComprimentoEntrada ValidarEObterEntrada(IElementoEntradaConversao entradaConversao)
        {
            var valores = Enum.GetValues(typeof(TipoMedida)).Cast<TipoMedida>();

            if (!(entradaConversao is ConversorMedidasDeComprimentoEntrada entradaConvertida) 
                || !valores.Contains(entradaConvertida.De) 
                || !valores.Contains(entradaConvertida.Para))
            {
                throw new ArgumentException("Entrada não é válida para o método");
            }

            return entradaConvertida;
        }

        private static string ObterDescricaoConversao(ConversorMedidasDeComprimentoEntrada entradaConvertida)
        {
            string nomeDe = Enum.GetName(typeof(TipoMedida), entradaConvertida.De);
            string nomePara = Enum.GetName(typeof(TipoMedida), entradaConvertida.Para);
            string descricao = $"A fórmula para converter {nomeDe} para {nomePara} e apenas multiplicar {nomeDe} por 10 elevado a potência {entradaConvertida.De - entradaConvertida.Para}";
            return descricao;
        }
    }
}
