using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    public delegate void dlgopera(int a, int b,ref int r);
    public delegate bool meupredicado(int n);
    class Utils
    {
        public IEnumerable<int>SacaNumeros(int limite, Predicate<int> predicado)
        {
            for (int i = 1; i <= limite; i++) {
                if (predicado(i)) yield return i;
            }
        }

        public bool EPrimo(int n)
        {
            if (n < 2) return false;
            int r,quoc,div = 2;
            do {
                r = n % div;
                quoc = n / div++;
            } while (r!=0 && quoc >=div);
            return n == 2 || r != 0;
        }
       

        public void soma(int x,int y, ref int rslt)
        {
            rslt += x + y;
            Console.WriteLine("Somando... {0}",rslt);
           
        }
        public void subtrai(int x,int y, ref int rslt)
        {
            rslt += x - y;
            Console.WriteLine("Subtraindo... {0}",rslt);
            
        }
    }
}
