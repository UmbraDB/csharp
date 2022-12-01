using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Nov15
{
    class Utilitarios
    {
        public int menu()
        {
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Troca");
            Console.WriteLine("3 - Estatistica");
            Console.WriteLine("4 - É primo");
            Console.WriteLine("5 - Mostrar Primos");
            Console.WriteLine("6 - Encher Array");
            Console.WriteLine("Escolha uma opção:");
            int op;
            if (int.TryParse(Console.ReadLine(), out op))
            {
                return op;
            }
            return -1;
        }
        public int soma(int a, int b)
        {
            return a + b;
        }
        public void troca(ref int a, ref int b)
        {
            int pivot = a;
            a = b;
            b = pivot;
        }
        public void estatistica(out float media, out float min, out float max, params float[] numeros)
        {
            max = min = media = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (max < numeros[i])
                {
                    max = numeros[i];
                }
                if (min > numeros[i])
                {
                    min = numeros[i];
                }
                media += numeros[i];
            }
            media /= (float)numeros.Length;
            Console.WriteLine("Numeros:");
            Array.Sort(numeros);
            foreach (float f in numeros) Console.Write("[{0}]", f);
        }
        public bool Eprimo(int n)
        {
            int div = 2, quoc, r;
            do
            {
                r = n % div;
                quoc = n / div++;
            }
            while (r != 0 && quoc >= div);
            return n == 2 || r != 0;

        }
        public IEnumerable<int> sacanumeros(int limite, Predicate<int> func)
        {
            for(int i=0; i < limite; i++)
            {
                if(func(i)) yield return i;
            }
        }

        public int[] encheArray()
        { 
            int i;
            bool continua = true;
            List<int> numeros=new List<int>();
            do
            {
                Console.WriteLine("intuduz numero");
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    numeros.Add(i);
                }
                else continua = false;
            } while (continua);
            return numeros.ToArray<int>();
        }
    }
}
