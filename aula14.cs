
using System.Globalization;

namespace Programa13
{
    class Programa14
    {
        static void Main(string[]Args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++) {
                if(numero % i == 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
