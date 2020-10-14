namespace TCC.Fernando.Especificacao1.Fronteira.Conversores.ConversorMedidas
{
    public class ConversorMedidasDeComprimentoSaida : IElementoConvertido
    {
        public readonly double Valor;
        public readonly string FormulaMedida;

        public ConversorMedidasDeComprimentoSaida(double valor, string formulaMedida)
        {
            Valor = valor;
            FormulaMedida = formulaMedida;
        }

        public string ObterFormulaMedida()
        {
            return FormulaMedida;
        }
    }
}
