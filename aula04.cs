namespace Programa4
{
    class Programa4
    {
        static void Main(string[]Args)
        {
            int numero;

            Console.Write("Qual é o numero desejado?");
            numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0){
                Console.WriteLine("Par");
            }

            else{
                Console.WriteLine("Impar");
            }

        }

    }

}