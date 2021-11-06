using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
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

        public override void AtaqueFichaLimpio(Tablero table)
        {
            {
                Tablero tabaux = new Tablero();
                tabaux.IniciarTablero();
                max = 0;
                
                for (i = 0; i < 8; i++)
                {
                    for (j = 0; j < 8; j++) //Se coloca la ficha en posicion
                    {   contador = 0;
                        for (int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            tabaux.tab[k, l] = table.tab[k, l];
                        }
                    }
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


        public override Tablero AtaqueFicha(Tablero table)//1+64n^2+1+n^2*(7n^2+156n+4n^2+144)+168n+4 = 64n^2+168n+6+9n^4+156n^3+144n^2 = 9n^4+156n^3+208n^2+168n+6
        {
            Tablero tabaux = new Tablero(); //1
            tabaux.IniciarTablero(); //64n^2
            max = 0;//1
            
            for (i = 0; i < 8; i++)//n
            {
                for (j = 0; j < 8; j++) //Se coloca la ficha en posicion n
                {contador = 0;//1
                    for (int k = 0; k < 8; k++)//n
                    {
                        for (int l = 0; l < 8; l++)//n
                        {
                            tabaux.tab[k, l] = table.tab[k, l];//7
                        }
                    }
                    for (k = -8; k < 8; k++) //Se cubren casillas horizontales n
                    {
                        if (i + k < 8 && i + k >= 0 && tabaux.tab[i + k, j] ==0) //13
                            tabaux.tab[i + k, j] = 1;//6
                    }
                    for (p = -8; p < 8; p++) //Se cubren casillas verticales n
                    {
                        if (j + p < 8 && j + p >= 0 && tabaux.tab[i, j + p] ==0) // 13
                            tabaux.tab[i, j + p] = 1;//6
                    }
                    for (a = 0; a < 8; a++)//n
                    {
                        for (b = 0; b < 8; b++) //Se cuentan las posiciones cubiertas n
                        {
                            if (tabaux.tab[a, b] == 1) // 4
                                contador++;//1
                        }
                    }
                    if (contador >= max) //Si se cubre la mayor cantidad de espacios, y el lugar no esta cubierto se coloca la ficha en esa posicion 3
                    {
                        if (table.tab[i, j] == 0 || table.tab[i, j] == 1) //8
                        {
                            max = contador;//2
                            PosH = i;//2
                            PosV = j;//2
                        }

                    }
                }
            }
            for (k = -8; k < 8; k++) //Se cubren casillas horizontales n
            {
                if (PosH + k < 8 && PosH + k >= 0 && table.tab[PosH + k, PosV] == 0) //14
                    table.tab[PosH + k, PosV] = 1;//6
            }
            for (p = -8; p < 8; p++) //Se cubren casillas verticales n
            {
                if (PosV + p < 8 && PosV + p >= 0 && table.tab[PosH, PosV + p] == 0) // 14
                    { table.tab[PosH, PosV + p] = 1; }//6
            }
            table.tab[PosH, PosV] = 5; //Una vez encontrada la mejor posicion se coloca la ficha ahi 4
            return table;
        }
    }
}
