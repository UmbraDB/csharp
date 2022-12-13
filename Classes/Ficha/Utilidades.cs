using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha
{
    class Utilidades
    {
        public int menu()
        {
            Console.WriteLine("0-Sair");
            Console.WriteLine("1-Inverter Número");
            Console.WriteLine("2-Selos");
            Console.WriteLine("3-Dobro");
            Console.WriteLine("4-Par");
            Console.WriteLine("5-Soma inteiros");
            Console.WriteLine("6-Somar Positivos");
            Console.WriteLine("7-Inverter numero de 100 a 999");
            Console.WriteLine("8-digito de controlo");
            Console.WriteLine("9-ordena numeros");
            Console.WriteLine("\t... escolha uma opção");
            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                return opcao;
            }
            else
            {
                Console.WriteLine("\n\anumero inválido");
                Console.ReadLine();
                return -1;
            }
        }
        public int inverterNum(int num)
        {
            int r, rslt = 0;
            do
            {
                r = num % 10;
                num /= 10;
                rslt = rslt * 10 + r;
            } while (num > 0);
            return rslt;
        }
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
                    switch (chang)
                    {
                        case 1:
                            if (cash == 1) troco++;
                            else
                            {
                                selo5--;
                                selo3++;
                            }
                            break;
                        case 2:
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
                            break;
                        case 3: selo3++;
                            break;
                        case 4:
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
                            break;
                        case 5: selo5++;
                            break;
                        case 6:
                            selo3++;
                            selo3++;
                            break;
                        case 7:
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
                            break;
                        default:
                            break;
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
            }
        }
        public float dobroNum(float num)
        {
            return num*2;
        }
        public int parNum(int num)
        {
            return num % 2;
        }
        public void inteiros()
        {
            int inteiros;
            int sum=1;
            Console.WriteLine("Quantas iterações pertende fazer?");
            bool check = int.TryParse(Console.ReadLine(), out inteiros);
            while (check == false || inteiros < 0)
            {
                Console.WriteLine("impossivel iterar");
                Console.WriteLine("Quantas iterações pertende fazer?");
                check = int.TryParse(Console.ReadLine(), out inteiros);
            }
            while (inteiros > 1)
            {
                sum += inteiros;
                inteiros--;
            }
            Console.WriteLine(sum);
        }
        public void somapos()
        {
            int soma = 0;
            int input = 0;
            bool check;
            Console.WriteLine("insira um numero para somar: (-1 Para sair)");
            for (; input != -1; Console.WriteLine("total:" + soma), Console.WriteLine("insira um numero positivo para somar: (-1 para sair)"))
            {
                    check = int.TryParse(Console.ReadLine(), out input);

                if (check == false)
                {
                    Console.WriteLine("valor invalido, insira um numero positivo para somar: (-1 Para sair)");
                    check = int.TryParse(Console.ReadLine(), out input);
                }
                else if (input >= 0)
                {
                    soma += input;
                }
                else if (input < -1)
                {
                    Console.WriteLine("valor tem de ser positivo, soma total = " + soma);
                    int.TryParse(Console.ReadLine(), out input);
                }
            }
        }
        public int controlNum(int num)
        {
            int uni = num - (num / 10 * 10);
            int dec = num / 10 - (num / 100 * 10);
            int cen = num / 100;
            return uni * 5 + dec * 3 + cen;
        }
        public void ordenaNum(int[] num)
        {
            int pivot;
            for (int i = 0; i < num.Length - 1; i++)
            {

                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        pivot = num[i];
                        num[i] = num[j];
                        num[j] = pivot;
                    }


                }
            }
        }
    }
}
