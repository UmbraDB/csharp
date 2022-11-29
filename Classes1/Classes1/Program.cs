using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    class Program
    {
        public delegate int Xpto(int a, int b);
        static void Main(string[] args)
        {
            Random r = new Random();
            Carro[] grelha = new Carro[] {
                new Carro("Fiat", "600"),
                new Carro("Ford", "Fiesta"),
                new Carro("Ferrari", "Enzo"),
                new Carro("Porsche", "911")
            };

            for (int v = 1; v <= 3; v++) {
                Console.WriteLine("----------(" + v.ToString() +")º. volta---------");
                foreach (Carro c in grelha) {
                    c.acelera(r.Next(200));
                }
            }
            //grelha[0] = new Carro("Fiat", "600");
            Console.WriteLine("\n Linha de Meta\n");
            Array.Sort(grelha);
            foreach (Carro c in grelha) c.ver();

            Console.WriteLine("Parabens ao carro vencedor\n");
            grelha[0].ver();
            Console.ReadLine();
        }
    }
}
