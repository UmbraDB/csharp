using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Casinonoite
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo.abreCasino();
            JogoDoisDados ze = new JogoDoisDados("Zé da Batota", 3000);
            ze.OnPremio += Ze_OnPremio;
            //JogoDoisDados maria = new JogoDoisDados("Maria das Dividas", 1000);
            //maria.ver();
            for (int i = 0; i < 10; i++)
            {
                ze.Jogar(new FICHAS[] { FICHAS.RED, FICHAS.RED, FICHAS.SILVER });
                Thread.Sleep(1000);
            }
            ze.ver();
            ze = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //maria.ver();
            //Jogo maria = new Jogo("Maria", 2000);
            //maria.ver();
            Console.ReadLine();
        }

        private static void Ze_OnPremio(JogoDoisDados sender, int aposta)
        {
            int premio = sender.Dados[0]*2*aposta;
            sender.Montante += premio;
            Console.WriteLine("Jackpot!"+ premio);
        }
    }
}