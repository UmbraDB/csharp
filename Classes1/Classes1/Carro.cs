using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    public class Carro :IComparable<Carro>
    {
        public String marca;
        public String modelo;
        public int velocidade;
        public int distancia;
        public Carro(String _marca, string _modelo)
        {
            this.marca = _marca;
            this.modelo = _modelo;
            this.velocidade = 0;
            this.distancia = 0;

        }
        public void ver()
        {
            Console.WriteLine("-------------("+ this.modelo +")-----------");
            Console.WriteLine("Marca:" +  this.marca);
            Console.WriteLine("Velocidade:{0} Distância:{1}", this.velocidade,this.distancia);
            Console.WriteLine("----------------------------------------------------------------");
        }

        public void acelera(int delta) {
            this.velocidade = delta;
            this.distancia += delta;
            this.ver();
        }

        public int CompareTo(Carro other)
        {
            return other.distancia - this.distancia;
        }
    }
}
