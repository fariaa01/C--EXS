
namespace programa15
{
    class programa16
    {

        static void Main(string[] args){
            pessoa x,y;

            x = new pessoa();
            y = new pessoa();

            Console.Write("Digite seu nome:");
            x.A = char.Parse(Console.ReadLine());

            Console.Write("Digite sua idade: ");
            x.B = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome de outra pessoa: ");
            y.A = char.Parse(Console.ReadLine());

            Console.Write("digite a idade da outra pessoa: ");
            y.B = int.Parse(Console.ReadLine());

            if(x.B > y.B ){
                Console.WriteLine("A pessoa mais velha é ", x.A);
            }

            else{
                Console.WriteLine("A pessoa mais velha é ", y.A);
            } 
       }
    }
}