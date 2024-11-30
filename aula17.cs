
namespace programa17
{
    class programa17
    {

        static void Main(string[] args){
            funcionario f1, f2;

            f1 = new funcionario();
            f2 = new funcionario();
            
            Console.WriteLine("Dados do prmeiro funcionario: ");

            Console.Write("Nome:");
            f1.nome = char.Parse(Console.ReadLine());

            Console.Write("Digite o salario");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");

            Console.Write("Nome:");
            f2.nome = char.Parse(Console.ReadLine());

            Console.Write("Digite o salario");
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine("Salario medio é de: {media}");

        } 
    }
}
