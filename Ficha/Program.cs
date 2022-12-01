using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Utilidades utilidades = new Utilidades();
            int op;
            int n;
            float a;
            do
            {
                Console.Clear();
                op = utilidades.menu();
                if (op == 0) break;
                if (op == -1) continue;
                switch (op)
                {
                    case 1:
                        Console.WriteLine("inversão de um numero");
                        Console.WriteLine("intruduza um numero");
                        try
                        {
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("o inverso de {0} = {1}",n,utilidades.inverterNum(n));
                            Console.ReadLine();
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("numero errado");
                        }
                        break;
                    case 2:
                        utilidades.selos();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("insira o numero a dobrar: ");
                        float.TryParse(Console.ReadLine(), out a);
                        Console.WriteLine(utilidades.dobroNum(a));
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("insira o numero: ");
                        int.TryParse(Console.ReadLine(), out n);
                        utilidades.parNum(n);
                        if (n == 0) Console.WriteLine("o numero é par");
                        else Console.WriteLine("o numero é impar");
                        Console.ReadLine();
                        break;
                    case 5:
                        utilidades.inteiros();
                        Console.ReadKey();
                        break;
                    case 6:
                        utilidades.somapos();
                        break;
                    case 7:
                        Console.WriteLine("Insira um numero de 100 a 999 para inverter");
                        try
                        {
                            n = int.Parse(Console.ReadLine());
                            if (n >= 100 && n <= 999)
                            {
                                Console.WriteLine("o inverso de {0} = {1}", n, utilidades.inverterNum(n));
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("numero inválido");
                                Console.ReadLine();
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("numero errado");
                        }
                        break;
                    case 8:
                        Console.WriteLine("insira um numero de 3 algarismo para gerar um checksum (unidades * 5 + dezenas * 3 + centenas)");
                        try
                        {
                            n = int.Parse(Console.ReadLine());
                            if (n >= 100 && n <= 999)
                            {
                                Console.WriteLine("checksum: " + utilidades.controlNum(n));
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("numero inválido");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("valor inválido");
                        
                        }
                        break;
                    case 9:
                        try
                        {
                            Console.WriteLine("insira 3 numeros para ordenar");

                            int[] ordena = new int[3];
                            for (int i = 0; i < 3; i++) {
                                Console.Write("Elemento {0}:" ,i+1);
                                ordena[i] = int.Parse(Console.ReadLine());
                            }
                            //foreach (int zz in ordena) Console.WriteLine(zz +"*");    

                            utilidades.ordenaNum(ordena);

                            foreach (int nn in ordena) Console.Write(nn + "-");
                           // Console.WriteLine(String.Join("-", ordena));
                            Console.ReadLine();
                           

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("numero invalido");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("opção inválida");
                        break;
                }
            }
            while (true);
        }
    }
}
