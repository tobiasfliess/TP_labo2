using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Tablero
    {
        
        public int LH;
        public int LV;
        public int[,] tab = new int[8, 8];

        public Tablero()
        {
            LH = 0;
            LV = 0;
            tab = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                { tab[i, j] = 0; }
            }
            

        }

        public void IniciarTablero()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    tab[i, k] = 0;
                }
            }

        }
        public void Imprimir()
        {
            for(int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    Console.Write(" " + tab[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static bool operator ==(Tablero t1, Tablero t2)
        {
            bool co = true;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (t1.tab[i, j] != t2.tab[i, j])
                        co = false;
                }
            }
            return co;
        }

        public static bool operator !=(Tablero t1, Tablero t2)
        { return !(t1 == t2); }

    }
}
