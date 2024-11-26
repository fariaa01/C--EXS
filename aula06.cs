namespace Programa6
{
    class Programa6
    {
        static void Main(string[]Args)
        {
         double salario,conta,conta2,conta3;

         Console.Write("Qual o valor do seu salario? ");
         salario = double.Parse(Console.ReadLine());

         conta = salario*0.08;
         conta2 = salario*0.18;
         conta3 = salario*0.28;

         if(salario < 2000){
            Console.WriteLine("É isento de imposto");
         }

         else if(salario < 3000){
            Console.WriteLine($"Seu imposto é de {conta}");
         }

         else if(salario < 4500){
            Console.WriteLine($"Seu imposto é de {conta2}");
         }

         else if(salario > 4500){
            Console.WriteLine($"Seu imposto é de {conta3}");
         }

         else{
            Console.Write("Por favor insira um numero válido");
         }
        }

    }

}