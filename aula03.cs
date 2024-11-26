namespace Programa3
{
    class Programa3
    {
        static void Main(string[]Args)
        {
            double numero;

            Console.Write("Qual sera o numero digitado?");
            numero = double.Parse(Console.ReadLine());

            if(numero < 0){
                Console.WriteLine("Negativo");
            }

            else{
                Console.WriteLine("Não negativo");
            }
        }

    }

}