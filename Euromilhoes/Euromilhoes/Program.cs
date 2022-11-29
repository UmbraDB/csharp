using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euromilhoes
{
    public struct Aposta
    {
        public const int MAXNUM = 50;
        public const int MAXESTRELA = 10;
        public int id;
        public int[] numeros;
        public int[] estrelas;
        int NumerosCertos;
        int EstrelasCertas;
        public Aposta(int pid)
        {
            this.id = pid;
            numeros = new int[5];
            estrelas = new int[2];
            NumerosCertos = 0;
            EstrelasCertas = 0;
        }
        public void apostar()
        {
            preenche(numeros, MAXNUM);
            preenche(estrelas, MAXESTRELA);
        }
        private void preenche(int[] xpto, int max)
        {
            for(int i = 0; i < xpto.Length; i++)
            {
                Random r = new Random();
                xpto[i] = r.Next(1,max+1);
                for(int j=0; j<i; j++)
                {
                    if(xpto[i] == xpto[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            Array.Sort(xpto);
        }
        public void ver()
        {
            Console.WriteLine("\n----------------------------<"+id.ToString()+"ªAposta >-------------------------------\n");
            Console.Write("Numeros::");
            foreach (int a in numeros) Console.Write(" {0:D2} ",a);
            Console.Write("Estrelas::");
            foreach (int j in estrelas) Console.Write(" {0:D2} ", j);
            Console.WriteLine("Chave: Numeros: {0} Estrelas:{1}", this.NumerosCertos, this.EstrelasCertas);
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Aposta> aposta = new List<Aposta>();
            Console.WriteLine("Quantas apostas?:");
            int total;
            if(int.TryParse(Console.ReadLine(), out total))
            {
                for(int i = 0; i < total; i++)
                {
                    aposta.Add(new Aposta(i));
                    aposta[i].apostar();
                    aposta[i].ver();
                }
            }
            else
            {
                Console.WriteLine("erro");
            }
            Console.ReadLine();
        }
    }
}
