using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov15
{
    //private - protected - internal - public
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilitarios utilitarios = new Utilitarios();
            int opcao, arg1, arg2;
            for (; ; )
            {
                
                Console.Clear();
                try
                {
                    opcao = utilitarios.menu();
                    if (opcao == 0) break;
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Algoritmo Soma");
                            Console.WriteLine("Introduza o 1 argumento");
                            arg1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introduza o 2 argumento");
                            arg2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Soma = {0}", utilitarios.soma(arg1, arg2));
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Algoritmo Troca");
                            Console.WriteLine("Introduza o 1 argumento");
                            arg1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introduza o 2 argumento");
                            arg2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Argumento 1:{0} - Argumento 2:{1}", arg1,arg2);
                            utilitarios.troca(ref arg1, ref arg2);
                            Console.WriteLine("Argumento 1:{0} - Argumento 2:{1}", arg1, arg2);
                            Console.ReadLine();
                            break;
                        case 3:
                            float media, min, max;
                            utilitarios.estatistica(out media, out min, out max, 1.2f, 3.4f,4,5,6,7,98324,132,1245);
                            Console.WriteLine("\nmedia:{0}, max:{1}, min{2}", media, max, min);
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Algoritmo Primos");
                            Console.WriteLine("Introduza o numero:");
                            arg1 = int.Parse(Console.ReadLine());
                            if (utilitarios.Eprimo(arg1) == true)
                            {
                                Console.WriteLine("o numero é primo");
                                Console.ReadLine();
                            }
                            else 
                            {
                                Console.WriteLine("o numero não é primo");
                                Console.ReadLine();
                            }
                            break;
                        case 5:
                            Console.WriteLine("Algoritmo Primos");
                            Console.WriteLine("Introduza o Primo Limite");
                            arg1 = int.Parse(Console.ReadLine());
                            var primos = utilitarios.sacanumeros(arg1, utilitarios.Eprimo);
                            foreach (int i in primos) Console.Write(i + ", ");
                            Console.ReadLine();
                            break;
                        case 6:
                            int[] xpto = utilitarios.encheArray();
                            foreach (int x in xpto) Console.WriteLine(x+"::");
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Opção não válida!");
                            Console.ReadLine();
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("Erro:" + erro.Message);
                    Console.ReadLine();

                }

            }       
          
        }
    }
}
