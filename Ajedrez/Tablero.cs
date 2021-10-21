using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez
{
    public class Tablero
    {
        public int LH;//posicion horizontal y vertical de la ficha
        public int LV;
        public int[,] tab = new int[8, 8];//un tablero de 8x8

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

        public void IniciarTablero()//ponemos el tablero en 0 todo (vacio)
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
