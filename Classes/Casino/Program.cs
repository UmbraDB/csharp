using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            for(int l=0; l<matriz.GetLength(0); l++)
            {
                for(int c = 0; c<matriz.GetLength(1); c++)
                {
                    Console.Write("{0:D2} ", matriz[l,c] );
                }
                Console.WriteLine("\n");
            }

            //jagged array
            int[][] dentucas = new int[3][];
            dentucas[0] = new int[] { 1, 2, 3, 4};
            dentucas[1] = new int[] { 5, 6};
            dentucas[2] = new int[] { 7, 8, 9};
            for(int l=0; l < dentucas.GetLength(0); l++)
            {
                for(int c = 0; c < dentucas[l].GetLength(0); c++)
                {
                    Console.Write("{0:D2} ", dentucas[l][c]);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
