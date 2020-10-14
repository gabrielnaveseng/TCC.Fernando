using System;
using System.Globalization;
using TCC.Fernando.Especificacao3.InterfaceUI;
using TCC.Fernando.Especificacao3.Nucleo;

namespace TCC.Fernando.Especificacao3
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                LerDados(out string opcaoEntrada,
                         out string valorEntrada_1,
                         out string valorEntrada_2,
                         out string quantidadeCasasDecimais);

                Calculadora calculadora = Leitor.ObterEntradaConversaoMedida(opcaoEntrada, valorEntrada_1, valorEntrada_2,
                    quantidadeCasasDecimais);

                double resultado = calculadora.Calcular();

                Console.WriteLine($"Valor: {resultado.ToString($"F{quantidadeCasasDecimais}", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Pressione qualquer tecla...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao efetuar operacao: {e.Message}");
            }
        }

        private static void LerDados(out string opcaoEntrada, out string valorEntrada_1, out string valorEntrada_2, out string quantidadeCasasDecimais)
        {
            Console.WriteLine("Calculadora");

            Console.WriteLine("Por favor, informe a operação desejada (*, +, -, /)");
            opcaoEntrada = Console.ReadLine();

            Console.WriteLine("Por favor, informe o valor da primeira entrada:");
            valorEntrada_1 = Console.ReadLine();

            Console.WriteLine("Por favor, informe o valor da segunda entrada:");
            valorEntrada_2 = Console.ReadLine();

            Console.WriteLine("Por favor, informe a quantidade de casas decimais (mínimo 0)");
            quantidadeCasasDecimais = Console.ReadLine();
        }
    }
}
