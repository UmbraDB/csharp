using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Notas1a5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int runtime = 1;
            while (runtime == 1)
            {
                Console.WriteLine("Insira uma nota de 1 a 5");
                int nota;
                if (!int.TryParse(Console.ReadLine(), out nota))
                {
                    Console.WriteLine("Insira uma nota válida");
                    continue;
                }
                else
                {
                    switch (nota)
                    {
                        case 1:
                            Console.WriteLine("Fraco");
                            break;
                        case 2:
                            Console.WriteLine("Não Satisfaz");
                            break;
                        case 3:
                            Console.WriteLine("Satisfaz");
                            break;
                        case 4:
                            Console.WriteLine("Bom");
                            break;
                        case 5:
                            Console.WriteLine("Excelente");
                            break;
                        default:
                            Console.WriteLine("Insira uma nota valida");
                            break;
                    }
                }
                Console.WriteLine("Correr o programa outra vez? (digite 1 para sim)");
                int check;
                if (!int.TryParse(Console.ReadLine(), out check))
                {
                    break;
                }
                else if (check == runtime)
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
