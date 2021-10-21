using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez
{
    public class Piezas
    {
        private int k;
        private int p;

        public int contador;
        public int max;

        public Piezas() // clase padre de todas las piesas
        {
            k = 0;
            p = 0;

            contador = 0;
            max = 0;

        }
        public void AtaqueFicha(Tablero table) { }
        public void AtaqueFichaLimpio(Tablero table) { }/*nos fijamos que en la ruta de ataque si 
                                                         curza con otra ficha corte el camino de ataque */

    }
}
