using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
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


        public override Tablero AtaqueFicha(Tablero table) //1+64n^2+1+7n^4+1+144+48+4n^2+120+4+144+48 = 7n^4+68n^2+511
        {
            Tablero tabaux = new Tablero(); //1
            tabaux.IniciarTablero();//64n^2
            max = 0;//1

            for (i = 0; i < 8; i++)//n
            {
                for (j = 0; j < 8; j++) //Se coloca la ficha en posicion //n
                {contador = 0;//1
                    for (int k = 0; k < 8; k++)//n
                    {
                        for (int l = 0; l < 8; l++)//n
                        {
                            tabaux.tab[k, l] = table.tab[k, l];//7
                        }
                    }
                    contador = 0;//1
                    if (i + 2 < 8 && i + 2 >= 0 && j + 1 < 8 && j + 1 >= 0 && tabaux.tab[i + 2, j + 1] == 0)//Se cubren los 8 posibles movimientos del caballo
                        tabaux.tab[i + 2, j + 1] = 1;
                    if (i + 2 < 8 && i + 2 >= 0 && j - 1 < 8 && j - 1 >= 0 && tabaux.tab[i + 2, j - 1] == 0) //18
                        tabaux.tab[i + 2, j - 1] = 1; //6
                    if (i - 2 < 8 && i - 2 >= 0 && j + 1 < 8 && j + 1 >= 0 && tabaux.tab[i - 2, j + 1] == 0)
                        tabaux.tab[i - 2, j + 1] = 1;
                    if (i - 2 < 8 && i - 2 >= 0 && j - 1 < 8 && j - 1 >= 0 && tabaux.tab[i - 2, j - 1] == 0)
                        tabaux.tab[i - 2, j - 1] = 1;
                    if (i + 1 < 8 && i + 1 >= 0 && j + 2 < 8 && j + 2 >= 0 && tabaux.tab[i + 1, j + 2] == 0)
                        tabaux.tab[i + 1, j + 2] = 1;
                    if (i + 1 < 8 && i + 1 >= 0 && j - 2 < 8 && j - 2 >= 0 && tabaux.tab[i + 1, j - 2] == 0)
                        tabaux.tab[i + 1, j - 2] = 1;
                    if (i - 1 < 8 && i - 1 >= 0 && j + 2 < 8 && j + 2 >= 0 && tabaux.tab[i - 1, j + 2] == 0)
                        tabaux.tab[i - 1, j + 2] = 1;
                    if (i - 1 < 8 && i - 1 >= 0 && j - 2 < 8 && j - 2 >= 0 && tabaux.tab[i - 1, j - 2] == 0)
                        tabaux.tab[i - 1, j - 2] = 1;


                    for (a = 0; a < 8; a++)//n
                    {
                        for (b = 0; b < 8; b++) //Se cuentan las posiciones cubiertas n
                        {
                            if (tabaux.tab[a, b] == 1)//3
                                contador++;//1
                        }
                    }
                    if (contador >= max) //Si se cubre la mayor cantidad de espacios, y el lugar no esta cubierto se coloca la ficha en esa posicion 
                    {
                        if (tabaux.tab[i, j] == 0 || tabaux.tab[i, j] == 1)//8
                        {
                            max = contador;//1
                            PosH = i;//2
                            PosV = j;//2
                        }

                    }
                }
            }

            if (PosH + 2 < 8 && PosH + 2 >= 0 && PosV + 1 < 8 && PosV + 1 >= 0 && table.tab[PosH + 2, PosV + 1] == 0)//Se cubren los 8 posibles movimientos del caballo
                table.tab[PosH + 2, PosV + 1] = 1;
            if (PosH + 2 < 8 && PosH + 2 >= 0 && PosV - 1 < 8 && PosV - 1 >= 0 && table.tab[PosH + 2, PosV - 1] == 0)//18
                table.tab[PosH + 2, PosV - 1] = 1;//6
            if (PosH - 2 < 8 && PosH - 2 >= 0 && PosV + 1 < 8 && PosV + 1 >= 0 && table.tab[PosH - 2, PosV + 1] == 0)
                table.tab[PosH - 2, PosV + 1] = 1;
            if (PosH - 2 < 8 && PosH - 2 >= 0 && PosV - 1 < 8 && PosV - 1 >= 0 && table.tab[PosH - 2, PosV - 1] == 0)
                table.tab[PosH - 2, PosV - 1] = 1;
            if (PosH + 1 < 8 && PosH + 1 >= 0 && PosV + 2 < 8 && PosV + 2 >= 0 && table.tab[PosH + 1, PosV + 2] == 0)
                table.tab[PosH + 1, PosV + 2] = 1;
            if (PosH + 1 < 8 && PosH + 1 >= 0 && PosV - 2 < 8 && PosV - 2 >= 0 && table.tab[PosH + 1, PosV - 2] == 0)
                table.tab[PosH + 1, PosV - 2] = 1;
            if (PosH - 1 < 8 && PosH - 1 >= 0 && PosV + 2 < 8 && PosV + 2 >= 0 && table.tab[PosH - 1, PosV + 2] == 0)
                table.tab[PosH - 1, PosV + 2] = 1;
            if (PosH - 1 < 8 && PosH - 1 >= 0 && PosV - 2 < 8 && PosV - 2 >= 0 && table.tab[PosH - 1, PosV - 2] == 0)
                table.tab[PosH - 1, PosV - 2] = 1;
            table.tab[PosH, PosV] = 4; //Una vez encontrada la mejor posicion se coloca la ficha ahi 4
            //table.Imprimir();
            return table;
           

        }
    }
}
