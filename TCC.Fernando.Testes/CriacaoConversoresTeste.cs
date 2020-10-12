using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TCC.Fernando.Especificacao1.Fabrica;
using TCC.Fernando.Especificacao1.Fronteira;
using TCC.Fernando.Especificacao1.Fronteira.Enums;
using TCC.Fernando.Especificacao1.Nucleo.ConversorMedidas;

namespace TCC.Fernando.Testes
{
    [TestClass]
    public class CriacaoConversoresTeste
    {
        [TestMethod]
        public void ConversorMedida()
        {
            IConversor conversor = FabricaDeConversor.ObterConversor(Conversores.MedidasDeComprimento);

            Assert.IsTrue(conversor is ConversorMedidasDeComprimento);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void ConversorInvalido()
        {
            _ = FabricaDeConversor.ObterConversor((Conversores) (-1));
        }
    }
}
