using System.Data.SqlTypes;

namespace Programa10
{
    class Programa
    {
        static void Main(string[]Args)
        {
            Console.Write("Quantos numeros voce quer digitar? ");
            int numero = int.Parse(Console.ReadLine());

            int soma = 0;

            for(int i = 1; i <numero; numero++){
                Console.Write("Valor #{0}" , i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }

            Console.WriteLine("Soma = " + soma);
        
        } 
    }
}