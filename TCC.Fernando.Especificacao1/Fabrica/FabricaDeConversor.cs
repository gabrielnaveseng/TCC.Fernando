using System;
using TCC.Fernando.Especificacao1.Fronteira;
using TCC.Fernando.Especificacao1.Fronteira.Enums;
using TCC.Fernando.Especificacao1.Nucleo.ConversorMedidas;

namespace TCC.Fernando.Especificacao1.Fabrica
{
    public static class FabricaDeConversor
    {
        public static IConversor ObterConversor(Conversores conversor)
        {
            return conversor switch
            {
                Conversores.MedidasDeComprimento => new ConversorMedidasDeComprimento(),
                _ => throw new NotImplementedException($"Conversor Nao Implementado. Tipo de conversor: {conversor}"),
            };
        }
    }
}
