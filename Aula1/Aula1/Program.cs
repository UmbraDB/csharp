using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilidades util = new Utilidades();
            //int n;
            //Console.WriteLine("Intruduza a nota:");
            //if(int.TryParse(Console.ReadLine(), out n))
            //{
            //    //util.escala(n);
            //    util.escalaII(n);
            //}
            //else 
            //{
            //    Console.WriteLine("Nota invalida");
            //}
            //Console.ReadLine();
            //exercicio 3
            //int x, y;
            //for (x = 1, y = 2; ; x++, y++) if (x == 4) break;
            //Console.WriteLine("x: " + x + "     y: " + y);
            //Console.ReadLine();
            //exercicio 4
            int x, y;
            for (x = 1, y = 2; x < 8; x++)
            {
                if (x % 2 == 0) continue;
                y += x;
            }
            Console.WriteLine(x + "  " + y);
            Console.ReadLine();
   
        }
    }
}
