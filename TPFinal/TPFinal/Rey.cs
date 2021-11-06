﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Rey : Piezas
    {
        private int i;
        private int j;
        private int k;
        private int p;
        private int PosV;
        private int PosH;
        private int a;
        private int b;

        public override void AtaqueFichaLimpio(Tablero table)
        {

            Tablero tabaux = new Tablero();
            tabaux.IniciarTablero();
            max = 0;
          
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++) //Se coloca la ficha en posicion
                {
                    contador = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            tabaux.tab[k, l] = table.tab[k, l];
                        }
                    }

                    for (k = -1; k < 1; k++) //Se cubren casillas horizontales
                    {
                        if (i + k < 8 && i + k >= 0)
                        {
                            if (!(tabaux.tab[i + k, j] == 0 || tabaux.tab[i + k, j] == 1))
                                break;
                            else
                                tabaux.tab[i + k, j] = 1;
                        }
                    }
                    for (p = -1; p < 1; p++) //Se cubren casillas verticales
                    {
                        if (j + p < 8 && j + p >= 0)
                        {
                            if (!(tabaux.tab[i, j + p] == 0 || tabaux.tab[i, j + p] == 1))
                                break;
                            else
                                tabaux.tab[i, j + p] = 1;
                        }
                    }
                    for (k = -1; k < 1; k++) //Se cubren casillas diagonales
                    {

                        if (i + k < 8 && i + k >= 0 && j + k < 8 && j + k >= 0)
                        {
                            if (!(tabaux.tab[i + k, j + k] == 0 || tabaux.tab[PosH + k, PosV + k] == 1))
                                break;
                            else
                                tabaux.tab[i + k, j + k] = 1;
                        } 
                        if (i - k < 8 && i - k >= 0 && j + k < 8 && j + k >= 0 && tabaux.tab[i - k, j + k] == 0)
                            {if (!(tabaux.tab[i - k, j + k] == 0 || tabaux.tab[PosH - k, PosV + k] == 1))
                                break;
                            else
                                tabaux.tab[i - k, j + k] = 1;}
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
                        if (table.tab[i, j] == 0 || table.tab[i, j] == 1 || table.tab[i, j] == 6)
                        {
                            max = contador;
                            PosH = i;
                            PosV = j;
                        }
                    }
                }
            }
            table.tab[PosH, PosV] = 3; //Una vez encontrada la mejor posicion se coloca la ficha ahi
            for (k = -1; k < 1; k++) //Se cubren casillas horizontales
            {
                if (i + k < 8 && i + k >= 0)
                    table.tab[PosH + k, PosV] = 1;
            }
            for (p = -1; p < 1; p++) //Se cubren casillas verticales
            {
                if (j + p < 8 && j + p >= 0)
                    table.tab[PosH, PosV + p] = 1;
            }
            for (k = -1; k < 1; k++) //Se cubren casillas diagonales
            {

                if (i + k < 8 && i + k >= 0 && j + k < 8 && j + k >= 0)
                    table.tab[k + PosH, k + PosV] = 1;
            }


        }

        public override Tablero AtaqueFicha(Tablero table)
        {
            Tablero tabaux = new Tablero();
            tabaux.IniciarTablero();
            max = 0;
            
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++) //Se coloca la ficha en posicion
                {contador = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            tabaux.tab[k, l] = table.tab[k, l];
                        }
                    }

                    for (k = -1; k < 1; k++) //Se cubren casillas horizontales
                    {
                        if (i + k < 8 && i + k >= 0 && tabaux.tab[i + k, j] ==0)
                            tabaux.tab[i + k, j] = 1;
                    }
                    for (p = -1; p < 1; p++) //Se cubren casillas verticales
                    {
                        if (j + p < 8 && j + p >= 0 && tabaux.tab[i, j + p] ==0)
                            tabaux.tab[i, j + p] = 1;
                    }
                    for (k = -1; k < 1; k++) //Se cubren casillas diagonales
                    {

                        if (i + k < 8 && i + k >= 0 && j + k < 8 && j + k >= 0 && tabaux.tab[i+k, j+k] ==0)
                            tabaux.tab[i+k, j+k] = 1;
                        if (i - k < 8 && i - k >= 0 && j + k < 8 && j + k >= 0 && tabaux.tab[i - k, j + k] == 0)
                            tabaux.tab[i - k, j + k] = 1;
                    }
                    for (a = 0; a < 8; a++)
                    {
                        for (b = 0; b < 8; b++) //Se cuentan las posiciones cubiertas
                        {
                            if (tabaux.tab[a, b] == 1)
                                contador++;
                        }
                    }
                    if (contador >= max) //Si se cubre la mayor cantidad de espacios, y el lugar no esta cubierto se coloca la ficha en esa posicion
                    {
                        if (table.tab[i, j] == 0 || table.tab[i, j] == 1 || table.tab[i, j] == 6)
                        {
                            max = contador;
                            PosH = i;
                            PosV = j;
                        }
                    }
                }
            }
            for (k = -1; k < 1; k++) //Se cubren casillas horizontales
            {
                if (PosH + k < 8 && PosH + k >= 0 && table.tab[PosH + k, PosV] == 0)
                    table.tab[PosH + k, PosV] = 1;
            }
            for (p = -1; p < 1; p++) //Se cubren casillas verticales
            {
                if (PosV + p < 8 && PosV + p >= 0 && table.tab[PosH, PosV + p] == 0)
                    table.tab[PosH, PosV + p] = 1;
            }
            for (k = -1; k < 1; k++) //Se cubren casillas diagonales
            {

                if (PosH + k < 8 && PosH + k >= 0 && PosV + k < 8 && PosV + k >= 0 && table.tab[k + PosH, k + PosV] == 0)
                    table.tab[k + PosH, k + PosV] = 1;
                if (PosH - k < 8 && PosH - k >= 0 && PosV + k < 8 && PosV + k >= 0 && table.tab[PosH - k, PosV + k] == 0)
                    table.tab[PosH - k, PosV + k] = 1;
            }
            table.tab[PosH, PosV] = 3; //Una vez encontrada la mejor posicion se coloca la ficha ahi
            return table;
        }
    }
}
