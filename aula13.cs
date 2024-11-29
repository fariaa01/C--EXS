
using System.Globalization;

namespace Programa13
{
    class Programa13
    {
        static void Main(string[]Args)
        {
            int numero = int.Parse(Console.ReadLine());


            for (int i = 0; i < numero; i++) {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }

        }
}


