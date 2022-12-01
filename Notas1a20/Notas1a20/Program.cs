using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Notas1a20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int runtime = 1;
            while (runtime == 1)
            {
                Console.WriteLine("Insira uma nota de 0 a 20");
                float nota;
                if (!float.TryParse(Console.ReadLine(), out nota))
                {
                    Console.WriteLine("Insira uma nota válida");
                    continue;
                }

                else if (nota >= 0 && nota < 10)
                {
                    Console.WriteLine($"A nota {nota} é Negativa");
                }
                else if (nota >= 10 && nota <= 20)
                {
                    Console.WriteLine($"A nota {nota} é Positiva");
                }
                else
                {
                    Console.WriteLine("Insira uma nota válida");
                }

                int check;
                Console.WriteLine("Deseja repetir o programa? (digite 1 se sim)");
                if (!int.TryParse(Console.ReadLine(), out check))
                {
                    break;
                }
                if (check == runtime)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
