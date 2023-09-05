using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");

            Coche miChoche = new Coche();
            miChoche.setRuedas(4);

            Console.WriteLine(miChoche.getRuedas());

            Moto miMoto = new Moto();

            miMoto.setRuedas(2);
            Console.WriteLine(miMoto.getRuedas());

        }
    }


    class Moto
    {
        public void setRuedas(int ruedas)
        {
            this.ruedas = ruedas;

        }
        public int getRuedas()
        {
            return ruedas;
        }

        private int ruedas;
    }
    class Coche
    {
        public void setRuedas(int ruedas)
        {
            this.ruedas = ruedas;

        }
        public int getRuedas()
        {
            return ruedas;
        }

        private int ruedas;
        
    }
}
