using System.Data;
using System.Security.AccessControl;

namespace Programa5
{
    class Programa5
    {
        static void Main(string[]Args)
        {
            int numero1,numero2;

            Console.Write("Qual sera o primeiro numero?");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Qual sera o segundo numero digitado?");
            numero2 = int.Parse(Console.ReadLine());

            if(numero1 % numero2 == 0){
                Console.WriteLine($"O numero {numero1} é multiplo de {numero2}");
            }

            else{
                Console.WriteLine($"O numero {numero1} não é multiplo de {numero2}");
            }


        }

    }

}