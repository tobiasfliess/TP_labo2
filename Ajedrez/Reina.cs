using System;
using System.Collections.Generic;
using System.Text;



namespace Ajedrez
{
    public class Reina : Piezas
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
            Tablero tabaux = table;
            max = 0;
            contador = 0;
            for (i = 3; i < 4; i++)
            {
                for (j = 2; j < 4; j++) //Se coloca la ficha en posicion del medio
                {
                    tabaux.IniciarTablero();
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
                        for (k = -8; k < 8; k++) //Se cubren casillas diagonales
                        {

                            if (k < 8 && k >= 0)
                            {
                                if (!(tabaux.tab[i + k, j + k] == 0 || tabaux.tab[PosH + k, PosV + k] == 1))
                                    break;
                                else
                                    tabaux.tab[i + k, j + k] = 1;
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
                            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
                            {
                                max = contador;
                                PosH = i;
                                PosV = j;
                            }

                        }
                    }
                }
                table.tab[PosH, PosV] = 2; //Una vez encontrada la mejor posicion se coloca la ficha ahi
                for (k = -8; k < 8; k++) //Se cubren casillas horizontales
                {
                    if (PosH + k < 8 && PosH + k >= 0)
                        table.tab[i + k, j] = 1;
                }
                for (p = -8; p < 8; p++) //Se cubren casillas verticales
                {
                    if (PosV + p < 8 && PosV + p >= 0)
                        table.tab[i, j + p] = 1;
                }
                for (k = -8; k < 8; k++) //Se cubren casillas diagonales
                {

                    if (k < 8 && k >= 0)
                        table.tab[k, k] = 1;
                }
            }
            void AtaqueFicha(Tablero table)
            {
                Tablero tabaux = table;
                max = 0;
                contador = 0;
                for (i = 3; i < 4; i++)
                {
                    for (j = 2; j < 4; j++) //Se coloca la ficha en posicion
                    {
                        tabaux.IniciarTablero();
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
                        for (k = -8; k < 8; k++) //Se cubren casillas diagonales
                        {

                            if (k < 8 && k >= 0)
                                tabaux.tab[k, k] = 1;
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
                            if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)
                            {
                                max = contador;
                                PosH = i;
                                PosV = j;
                            }

                        }
                    }
                }
                table.tab[PosH, PosV] = 2; //Una vez encontrada la mejor posicion se coloca la ficha ahi
                for (k = -8; k < 8; k++) //Se cubren casillas horizontales
                {
                    if (PosH + k < 8 && PosH + k >= 0)
                        table.tab[i + k, j] = 1;
                }
                for (p = -8; p < 8; p++) //Se cubren casillas verticales
                {
                    if (PosV + p < 8 && PosV + p >= 0)
                        table.tab[i, j + p] = 1;
                }
                for (k = -8; k < 8; k++) //Se cubren casillas diagonales
                {

                    if (k < 8 && k >= 0)
                        table.tab[k, k] = 1;
                }

            }
        }
    }
}