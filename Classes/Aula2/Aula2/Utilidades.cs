using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    public class Utilidades
    {
        public void selos()
        {
            int cash, selo3 = 0, selo5 = 0, count = 8, chang, troco = 0;
            try
            {
                Console.WriteLine("insira dinheiro: ");
                cash = int.Parse(Console.ReadLine());
                chang = cash % count;
                selo3 = cash / count;
                selo5 = cash / count;
                if (cash > 0)
                {
                    if (chang == 1)
                    {
                        if (cash == 1) troco++;
                        else
                        {
                            selo5--;
                            selo3++;
                        }
                    }

                    else if (chang == 2)
                    {
                        if (cash == 2)
                        {
                            troco++;
                            troco++;
                        }
                        else
                        {
                            selo3--;
                            selo5++;
                        }
                    }
                    else if (chang == 3) selo3++;

                    else if (chang == 4)
                    {
                        if (cash == 4)
                        {
                            selo3++;
                            troco++;
                        }
                        else
                        {
                            selo5--;
                            selo3++;
                            selo3++;
                            selo3++;
                        }
                    }
                    else if (chang == 5) selo5++;

                    else if (chang == 6)
                    {
                        selo3++;
                        selo3++;
                    }
                    else if (chang == 7)
                    {
                        if (cash == 5)
                        {
                            selo3++;
                            selo3++;
                            troco++;
                        }
                        else
                        {
                            selo3--;
                            selo5++;
                            selo5++;
                        }
                    }
                    Console.WriteLine("selo 3: " + selo3);
                    Console.WriteLine("selo 5: " + selo5);
                    Console.WriteLine("troco:" + troco);

                }
                else
                {
                    Console.WriteLine("Quantia invalida");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Quantia invalida.");
                ;
            }
        }
        public void inverter()
        {
            try
            {
                Console.WriteLine("insira um valor para inverter");
                int a = int.Parse(Console.ReadLine());
                int n = a;
                int b = 0;
                int r = 0;
                do
                {
                    r = a % 10;
                    b = b * 10 + r;
                    a = a / 10;
                }

                while (a > 0);
                Console.WriteLine(b);
                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("valor invalido");
            }
        }
    }
}
