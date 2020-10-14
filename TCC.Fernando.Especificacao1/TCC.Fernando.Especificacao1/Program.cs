using System;
using System.Text;
using TCC.Fernando.Especificacao1.Fabrica;
using TCC.Fernando.Especificacao1.Fronteira;
using TCC.Fernando.Especificacao1.Fronteira.Conversores.ConversorMedidas;
using TCC.Fernando.Especificacao1.Fronteira.Enums;
using TCC.Fernando.Especificacao1.InterfaceUI;

namespace TCC.Fernando.Especificacao1
{
    public class Program
    {
        public static void Main()
        {
            LerDados(out string opcaoEntrada,
                     out string valorEntrada,
                     out string opcaoSaida);

            ConversorMedidasDeComprimentoEntrada entradaConversao = Leitor.ObterEntradaConversaoMedida(opcaoEntrada,
                                                                                                       valorEntrada,
                                                                                                       opcaoSaida);

            IConversor conversor = FabricaDeConversor.ObterConversor(Conversores.MedidasDeComprimento);
            var saidaConversao = (ConversorMedidasDeComprimentoSaida)conversor.Converter(entradaConversao);

            Console.WriteLine($"Formula medida: {saidaConversao.ObterFormulaMedida()}");
            Console.WriteLine($"Valor destino: {saidaConversao.Valor}");
            Console.WriteLine("Pressione qualquer tecla...");
            Console.ReadKey();
        }

        private static void LerDados(out string opcaoEntrada, out string valorEntrada, out string opcaoSaida)
        {
            Console.WriteLine("Conversor de medidas");
            string descricaoMedida = ObterDescricaoMedida();

            Console.WriteLine("Por favor, informe a unidade de medida atual:");
            Console.Write(descricaoMedida);
            opcaoEntrada = Console.ReadLine();
            Console.WriteLine("Por favor, informe o valor de entrada:");
            valorEntrada = Console.ReadLine();
            Console.WriteLine("Por favor, informe a unidade de medida destino:");
            Console.Write(descricaoMedida);
            opcaoSaida = Console.ReadLine();
        }

        private static string ObterDescricaoMedida()
        {
            var str = new StringBuilder();
            var medidas = Enum.GetValues(typeof(TipoMedida));
            foreach (var tipoMedida in medidas)
            {
                str.AppendLine($"Opcao {(int)tipoMedida}: {Enum.GetName(typeof(TipoMedida), tipoMedida)}");
            }

            return str.ToString();
        }

    }
}
