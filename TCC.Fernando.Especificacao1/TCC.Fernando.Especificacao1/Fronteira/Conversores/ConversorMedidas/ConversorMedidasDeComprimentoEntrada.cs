namespace TCC.Fernando.Especificacao1.Fronteira.Conversores.ConversorMedidas
{
    public class ConversorMedidasDeComprimentoEntrada : IElementoEntradaConversao
    {
        public double Valor { get; set; }
        public TipoMedida De { get; set; }
        public TipoMedida Para { get; set; }
    }
}
