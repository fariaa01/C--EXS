namespace Programa
{
    class Programa1
    {
        static void Main(string[] args)
        {
            double dolar = 5.5;
            double number;
            double conta;

        
            Console.Write("Digite o seu salário: ");
            number = double.Parse(Console.ReadLine());

            
            conta = number / dolar;

            Console.WriteLine($"Seu salário é R$ {number}, e em dólares é $ {conta:F2}");
        }
    }
}