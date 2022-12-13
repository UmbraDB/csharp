using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.ReadKey();
                switch
                Utilidades utilidades = new Utilidades();
                utilidades.inverter();
            }
        }
    }
}
