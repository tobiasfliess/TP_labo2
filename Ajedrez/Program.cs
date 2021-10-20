using System;

//Reina =2
//Rey = 3
//Caballo =4
//Torre =5
//Alfil =6



//------------------------------------------------
/* algoritmo para espejar el resultado

int aux;

for(int i=0; i<7; i++)
{
    for(int j=0; j<4; j++)// va del 0-3 y los espeja con 4-7
    {
        aux= table.tab[i,j]
        table.tab[i,j] = table.tab[i,7-j];
        table.tab[i, 7-j]= aux;
    }

}

 no es lo mismo espejar que rotar 180º
*/
//---------------------------------------------------
namespace Ajedrez
{
    class Program
    {
        //public void OrdenAleatorio(Piezas[] pieza)
        //{
        //    Random rnd = new Random();
        //    int random = rnd.Next(0, 3);
        //    Piezas aux;
        //    aux = pieza[random];
        //    pieza[2] = pieza[random];
        //    pieza[random] = aux;


        //}
        static void Main(string[] args)
        {
            int Cantidad_Soluciones = 10;
            int Contador_Soluciones = 0;

            Tablero tablero = new Tablero();
            Reina reina = new Reina();
            Rey rey = new Rey();
            Caballo caballo = new Caballo();
            Torre torre = new Torre();
            Alfil alfil = new Alfil();

            Tablero[] Vtable = new Tablero[10];

            tablero.IniciarTablero();

            int cont = 0;
            int cont2 = 0;

            Piezas[] pieza = new Piezas[4];
            pieza[3] = rey;
            pieza[2] = caballo;
            pieza[1] = torre;
            pieza[0] = alfil;

            // OrdenAleatorio(pieza);


            while (Contador_Soluciones != Cantidad_Soluciones)
            {
                Random rnd = new Random();
                int random = rnd.Next(0, 3);
                Piezas aux;
                aux = pieza[random];
                pieza[2] = pieza[random];
                pieza[random] = aux;

                reina.AtaqueFicha(tablero);
                for (int i = 0; i < 3; i++)
                { pieza[i].AtaqueFicha(tablero); }

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (tablero.tab[i, j] == 0)
                        {
                            cont++;
                            break;
                        }
                    }

                }
                if (cont == 0)
                {
                     Console.WriteLine("se cubre todo el tablero");
                    for (int i = 0; i < 10; i++)
                    {
                        if (Vtable[i].tab == tablero.tab)
                        {
                            cont2++;
                        }
                    }
                }
                if (cont2 == 0)
                {
                    Console.WriteLine( "es una solucion nueva");
                    Vtable[Contador_Soluciones] = tablero;
                    Contador_Soluciones++;
                }
                //Una vez hecho el form mostraremos ahi los resultados con imagenes de los tableros solucion
            }
        }
    }
}

