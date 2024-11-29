using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace programa15
{
    class programa15
    {

        static void Main(string[] args){
            triangulo x, y;

            x = new triangulo();
            y = new triangulo();

            Console.WriteLine("Digite os valores de x: ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os valores de y: ");

            y.A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

             p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY){
                Console.WriteLine("Area de x é maior");
            }

            else{
                Console.WriteLine("Area de y é maior");
            }


            

       }
    }
}