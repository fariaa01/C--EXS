
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace Programa12
{
    class Programa12
    {
        static void Main(string[]Args)
        {
            int numero = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for(int i = 1;i <=numero;i++){
                int x = int.Parse(Console.ReadLine());
                if(x < 10 && x >20 ){
                    cont_in = cont_in +1;
                }

                else(x =>10 && x <= 20 ){
                    cont_out = cont_out + 1;
                }

                Console.WriteLine(cont_in + "in");
                Console.WriteLine(cont_out + "out");
            }

        }
        }

    }
