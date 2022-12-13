using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Casinonoite
{
    public delegate void OnPremio_Handler(JogoDoisDados sender, int aposta);
    public class JogoDoisDados : Jogo
    {
        Random r = new Random();
        public int[] Dados = new int[] { 1, 1 };

        public override void ver()
        {
            base.ver();
            Console.WriteLine("Total de Jogadores no casino: {0}", Jogo.total);
            Console.WriteLine("Dados 1: {0} Dados 2: {1}", Dados[0], Dados[1]);
        }
        public JogoDoisDados(string jogador) : base(jogador)
        {
        }

        public JogoDoisDados(string jogador, int montante) : base(jogador, montante)
        {
        }
        
        public event OnPremio_Handler OnPremio;


        public override void Jogar(FICHAS[] aposta)
        {
            int euros = 0;
            foreach (FICHAS f in aposta) euros += (int)f;
            if (Montante >= euros)
            {
                this.Montante -= euros;
            }
            else if (this.Montante > 0)
            {
                euros = this.Montante;
                this.Montante = 0;
            }
            else euros = 0;
            if (euros > 0)
            {
                Random r = new Random();
                this.Dados[0] = r.Next(1, 7);
                this.Dados[1] = r.Next(1, 7);
                if (Dados[0] == Dados[1]) OnPremio(this, euros);
            }
            ver();
        }
    }
}
