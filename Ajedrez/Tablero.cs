using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez
{
    public class Tablero
    {
        public int LH;
        public int LV;
        public int[,] tab = new int[8, 8];

       public Tablero()
        { LH = 0;
            LV = 0;
            tab = new int[8, 8];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                { tab[i, j] = 0; }
            }

        }

        public void IniciarTablero()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int k = 0; k < 7; k++)
                {
                    tab[i, k] = 0;
                }
            }

        }
    }
}
