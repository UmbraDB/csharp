using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casinonoite
{
    public enum FICHAS
    {
        RED=10,
        GREEN=15,
        BLUE=25,
        SILVER=50,
        GOLD=100
    }
    public abstract class Jogo
    {
        public const int MAXAPOSTA = 250;
        public static int total;
        public static void abreCasino()
        {
            Console.WriteLine("Casino do ISTEC");
            Console.WriteLine("Total de jogadores no casino: " + total);
            Console.WriteLine("Aposta Máxima: " + Jogo.MAXAPOSTA);
            Console.WriteLine("Fichas disponiveis");
            foreach(FICHAS f in Enum.GetValues(typeof(FICHAS)))
            {
                Console.WriteLine("\t" + f + "->" + (int)f + "$");
            }
        }

        #region Campos e propriedades
        private string _jogador;
        protected int _montante;
        public string Jogador
        {
            get { return _jogador; }
        }
        public int Montante
        {
            get { return _montante; }
            set
            {
                if (value >= 0) this._montante = value;
            }
        }
        #endregion
        public Jogo(string jogador)
        {
            this._jogador = jogador;
            Jogo.total++;
        }
        //overloading dois metodos com o mesmo nome e parametros diferentes
        public Jogo(string jogador, int montante):this(jogador)
        {
            this.Montante = montante;
        }
        ~Jogo()
        {
            Console.WriteLine("Destruindo o " + this.Jogador);
            Jogo.total--;
        }
        //override so e permitido em metodos abstractos ou virtuais
        public virtual void ver()
        {
            Console.WriteLine("----------<" + _jogador);
            Console.WriteLine("----------<" + _montante + "€");
        }
        public abstract void Jogar(FICHAS[] aposta);



    }
}
