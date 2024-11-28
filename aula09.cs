using System;
using System.Net.Mail;

namespace Program9
{
    class Programa9
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int diesel = 0;
            int gasolina = 0;

            int numero = int.Parse(Console.ReadLine());

            while(numero != 4){
                if(numero == 1){
                    alcool = alcool + 1;
                } 
                else if(numero == 2){
                    gasolina = gasolina + 1;
                }

                else if(numero == 3){
                    diesel = diesel + 1;
                }

                numero = int.Parse(Console.ReadLine());
            }

             Console.WriteLine("MUITO OBRIGADO");
             Console.WriteLine("Alcool: " + alcool);
             Console.WriteLine("Gasolina: " + gasolina);
             Console.WriteLine("Diesel" + diesel);
        }
        }
    }

