namespace Programa
{
    class Programa2
    {
        static void Main(string[] args)
        {
         double A,B,C;
         double triangulo, circulo, trapezio, quadrado, retangulo;

         Console.Write("digite o numero A:");
         A = double.Parse(Console.ReadLine());

         Console.Write("digite o numero A:");
         B = double.Parse(Console.ReadLine());

         Console.Write("digite o numero A:");
         C = double.Parse(Console.ReadLine());

         triangulo = A*C;
         circulo = 3.14159 * A * A;
         trapezio = ((A + B) * C) / 2;
         quadrado = B*B;
         retangulo = B*C;

         Console.WriteLine($"Area do triangulo é: {triangulo:F2}");
         Console.WriteLine($"Area do circulo é: {circulo:F2}");
         Console.WriteLine($"Area do trapezio é: {trapezio:F2}");
         Console.WriteLine($"Area do quadrado é: {quadrado:F2}");
         Console.WriteLine($"Area do retangulo é: {retangulo:F2}");
        } 
    }
}