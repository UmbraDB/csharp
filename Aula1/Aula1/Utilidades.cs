using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Utilidades
    {
        public void escala(int nota)
        {
            if(nota >= 0 && nota <= 5) 
            {
                if (nota <= 1) Console.WriteLine("Fraco");
                else if (nota <= 2) Console.WriteLine("Não Satisfaz");
                else if (nota <= 3) Console.WriteLine("Satisfaz");
                else if (nota <= 4) Console.WriteLine("Bom");
                else Console.WriteLine("Excelente");
            }
            else
            {
                Console.WriteLine("\n\aErro\n");
            }
        }
        public void escalaII(int nota)
        {
            switch(nota)
            {
                case 1:
                    Console.WriteLine("fraco");
                    break;
                case 2:
                    Console.WriteLine("não satifaz");
                    break;
                case 3:
                    Console.WriteLine("satifaz");
                    break;
                case 4:
                    Console.WriteLine("bom");
                    break;
                case 5:
                    Console.WriteLine("excelente");
                    break;
                default:
                    Console.WriteLine("erro");
                    break;
            }
        }
    }
}
