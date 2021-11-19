using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Piezas
    {
        private int k;
        private int p;

        public int contador;
        public int max;

        public Piezas()
        {
            k = 0;
            p = 0;

            contador = 0;
            max = 0;

        }
        public virtual Tablero AtaqueFicha(Tablero table) {
            return table;
        }
        public virtual void AtaqueFichaLimpio(Tablero table) { }

        

    }
}
