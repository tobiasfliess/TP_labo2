using System;
using System.Collections.Generic;
using System.Text;

namespace Ajedrez
{
    public class Torre : Piezas
    {
        private int i;
        private int j;
        private int k;
        private int p;
        private int PosV;
        private int PosH;
        private int a;
        private int b;

        public void AtaqueFichaLimpio(Tablero table)
        {
            {
                Tablero tabaux = table;
                max = 0;
                contador = 0;
                for (i = 0; i < 8; i++)
                {
                    for (j = 0; j < 8; j++) //Se coloca la ficha en posicion
                    {
                        for (k = -8; k < 8; k++) //Se cubren casillas horizontales
                        {
                            if (i + k < 8 && i + k >= 0)
                            {
                                if (!(tabaux.tab[i + k, j] == 0 || tabaux.tab[i + k, j] == 1))
                                    break;
                                else
                                    tabaux.tab[i + k, j] = 1;
                            }
                        }
                        for (p = -8; p < 8; p++) //Se cubren casillas verticales
                        {
                            if (j + p < 8 && j + p >= 0)
                            {
                                if (!(tabaux.tab[i, j + p] == 0 || tabaux.tab[i, j + p] == 1))
                                    break;
                                else
                                    tabaux.tab[i, j + p] = 1;
                            }
                        }
                        for (a = 0; a < 8; a++)
                        {
                            for (b = 0; b < 8; b++) //Se cuentan las posiciones cubiertas
                            {
                                if (tabaux.tab[a, b] == 1)
                                    contador++;
                            }
                        }
                        if (contador > max) //Si se cubre la mayor cantidad de espacios, y el lugar no esta cubierto se coloca la ficha en esa posicion
                        {
                            if (table.tab[i, j] == 0 || table.tab[i, j] == 1)
                            {
                                max = contador;
                                PosH = i;
                                PosV = j;
                            }

                        }
                    }
                }
                table.tab[PosH, PosV] = 5; //Una vez encontrada la mejor posicion se coloca la ficha ahi
                for (k = -8; k < 8; k++) //Se cubren casillas horizontales
                {
                    if (i + k < 8 && i + k >= 0)
                        table.tab[PosH + k, PosV] = 1;
                }
                for (p = -8; p < 8; p++) //Se cubren casillas verticales
                {
                    if (j + p < 8 && j + p >= 0)
                        if (table.tab[PosH, PosV + p] == 0)
                        { table.tab[PosH, PosV + p] = 1; }
                }

            }
        }


        public void AtaqueFicha(Tablero table)
        {
            Tablero tabaux = table;
            max = 0;
            contador = 0;
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++) //Se coloca la ficha en posicion
                {
                    for (k = -8; k < 8; k++) //Se cubren casillas horizontales
                    {
                        if (i + k < 8 && i + k >= 0)
                            tabaux.tab[i + k, j] = 1;
                    }
                    for (p = -8; p < 8; p++) //Se cubren casillas verticales
                    {
                        if (j + p < 8 && j + p >= 0)
                            tabaux.tab[i, j + p] = 1;
                    }
                    for (a = 0; a < 8; a++)
                    {
                        for (b = 0; b < 8; b++) //Se cuentan las posiciones cubiertas
                        {
                            if (tabaux.tab[a, b] == 1)
                                contador++;
                        }
                    }
                    if (contador > max) //Si se cubre la mayor cantidad de espacios, y el lugar no esta cubierto se coloca la ficha en esa posicion
                    {
                        if (table.tab[i, j] == 0 || table.tab[i, j] == 1)
                        {
                            max = contador;
                            PosH = i;
                            PosV = j;
                        }

                    }
                }
            }
            table.tab[PosH, PosV] = 5; //Una vez encontrada la mejor posicion se coloca la ficha ahi
            for (k = -8; k < 8; k++) //Se cubren casillas horizontales
            {
                if (i + k < 8 && i + k >= 0)
                    table.tab[PosH + k, PosV] = 1;
            }
            for (p = -8; p < 8; p++) //Se cubren casillas verticales
            {
                if (j + p < 8 && j + p >= 0)
                    if (table.tab[PosH, PosV + p] == 0)
                    { table.tab[PosH, PosV + p] = 1; }
            }

        }
    }
}
