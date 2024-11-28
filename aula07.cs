using System;

namespace Program7
{
    class Programa7
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Digite números para calcular a raiz quadrada (digite um número negativo para sair):");

            while (true)
            {
                Console.Write("Digite um número: ");
                if (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                    continue;
                }

                if (numero < 0)
                {
                    Console.WriteLine("Número negativo detectado. Encerrando o programa...");
                    break;
                }

                double conta = Math.Sqrt(numero);
                Console.WriteLine($"A raiz quadrada de {numero} é: {conta:F2}");
            }
        }
    }
}
