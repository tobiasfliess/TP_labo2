using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez
{
    public class Caballo : Piezas
    {
        private int i;
        private int j;
        private int k;
        private int p;
        private int PosV;
        private int PosH;
        private int a;
        private int b;


        public void AtaqueFicha(Tablero table)
        {
            Tablero tabaux = table;
            max = 0;

            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++) //Se coloca la ficha en posicion
                {
                    contador = 0;
                    if(i+2<7 && i+2>=0 && j + 1 < 7 && j + 1 >= 0)//Se cubren los 8 posibles movimientos del caballo
                        tabaux.tab[i + 2, j + 1] = 1;
                    if (i + 2 < 7 && i + 2 >= 0 && j - 1 < 7 && j - 1 >= 0)
                        tabaux.tab[i + 2, j - 1] = 1;
                    if (i - 2 < 7 && i - 2 >= 0 && j + 1 < 7 && j + 1 >= 0)
                        tabaux.tab[i - 2, j + 1] = 1;
                    if (i - 2 < 7 && i - 2 >= 0 && j - 1 < 7 && j - 1 >= 0)
                        tabaux.tab[i - 2, j - 1] = 1;
                    if (i + 1 < 7 && i + 1 >= 0 && j + 2 < 7 && j + 2 >= 0)
                        tabaux.tab[i + 1, j + 2] = 1;
                    if (i + 1 < 7 && i + 1 >= 0 && j -2 < 7 && j -2 >= 0)
                        tabaux.tab[i + 1, j - 2] = 1;
                    if (i - 1 < 7 && i - 1 >= 0 && j + 2 < 7 && j + 2 >= 0)
                        tabaux.tab[i - 1, j + 2] = 1;
                    if (i - 1 < 7 && i - 1 >= 0 && j - 2 < 7 && j - 2 >= 0)
                        tabaux.tab[i - 1, j - 2] = 1;


                    for (a = 0; a < 7; a++)
                    {
                        for (b = 0; b < 7; b++) //Se cuentan las posiciones cubiertas
                        {
                            if (tabaux.tab[a, b] == 1)
                                contador++;
                        }
                    }
                    if (contador > max) //Si se cubre la mayor cantidad de espacios, y el lugar no esta cubierto se coloca la ficha en esa posicion
                    {
                        if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
                        {
                            max = contador;
                            PosH = i;
                            PosV = j;
                        }

                    }
                }
            }
            table.tab[PosH, PosV] = 4; //Una vez encontrada la mejor posicion se coloca la ficha ahi
            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
            if (table.tab[PosH, PosV + p] == 0)
                    table.tab[PosH + 2, PosV + 1] = 1; //Se cubren los 8 posibles movimientos del caballo
            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
            if (table.tab[PosH, PosV + p] == 0)
                    table.tab[PosH + 2, PosV - 1] = 1;
            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
            if (table.tab[PosH, PosV + p] == 0)
                    table.tab[PosH - 2, PosV + 1] = 1;
            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
            if (table.tab[PosH, PosV + p] == 0)
                    table.tab[PosH - 2, PosV - 1] = 1;
            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
            if (table.tab[PosH, PosV + p] == 0)
                    table.tab[PosH + 1, PosV + 2] = 1;
            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
            if (table.tab[PosH, PosV + p] == 0)
                    table.tab[PosH + 1, PosV - 2] = 1;
            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
                table.tab[PosH - 1, PosV + 2] = 1;
            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
            if (table.tab[PosH, PosV + p] == 0)
                    table.tab[PosH - 1, PosV - 2] = 1;
            
        }
    }
}
