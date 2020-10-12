using System;
using System.Text;
using TCC.Fernando.Especificacao1.Fabrica;
using TCC.Fernando.Especificacao1.Fronteira;
using TCC.Fernando.Especificacao1.Fronteira.Conversores.ConversorMedidas;
using TCC.Fernando.Especificacao1.Fronteira.Enums;

namespace TCC.Fernando.Especificacao1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de medidas");
            string str = ObterDescricaoMedida();

            Console.WriteLine("Por favor, informe a unidade de medida atual:");
            Console.Write(str);            
            var opcaoEntrada = Console.ReadLine();

            Console.WriteLine("Por favor, informe o valor de entrada:");
            var valorEntrada = Console.ReadLine();

            Console.WriteLine("Por favor, informe a unidade de medida destino:");
            Console.Write(str);
            var opcaoSaida = Console.ReadLine();

            IConversor conversor = FabricaDeConversor.ObterConversor(Conversores.MedidasDeComprimento);

            var entradaConversao = new ConversorMedidasDeComprimentoEntrada()
            {
                De = (TipoMedida) Convert.ToInt32(opcaoEntrada),
                Para = (TipoMedida) Convert.ToInt32(opcaoSaida),
                Valor = Convert.ToDouble(valorEntrada)
            };

            var saidaConversao = (ConversorMedidasDeComprimentoSaida)conversor.Converter(entradaConversao);

            Console.WriteLine($"Formula medida: {saidaConversao.ObterFormulaMedida()}");
            Console.WriteLine($"Valor destino: {saidaConversao.Valor}");
        }

        private static string ObterDescricaoMedida()
        {
            var str = new StringBuilder();
            var medidas = Enum.GetValues(typeof(TipoMedida));
            foreach (var tipoMedida in medidas)
            {
                str.AppendLine($"Opcao {(int) tipoMedida}: {Enum.GetName(typeof(TipoMedida), tipoMedida)}");
            }

            return str.ToString();
        }
    }
}
