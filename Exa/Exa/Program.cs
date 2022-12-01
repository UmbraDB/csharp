using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            while (x < 3)
            {
                y += x++;
            }
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
