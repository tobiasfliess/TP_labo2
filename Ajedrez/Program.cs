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
   
        static void Main(string[] args)
        {
            int Cantidad_Soluciones = 10;// para hacer 10 tableros distintos
            int Contador_Soluciones = 0;

            Tablero tablero = new Tablero();
            Reina reina = new Reina();
            Rey rey = new Rey();
            Caballo caballo = new Caballo();
            Torre torre = new Torre();
            Alfil alfil = new Alfil();

            Tablero[] Vtable = new Tablero[10];

            tablero.IniciarTablero();//poner tablero en 0

            int cont = 0;
            int cont2 = 0;

            Piezas[] pieza = new Piezas[4];//guardamos las piezas en un array, manteniendo el orden optimo
            pieza[3] = rey;
            pieza[2] = caballo;
            pieza[1] = torre;
            pieza[0] = alfil;

            // OrdenAleatorio(pieza);


            while (Contador_Soluciones != Cantidad_Soluciones)
            {
                Random rnd = new Random();//cambia de orden una pieza al azar con el caballo
                int random = rnd.Next(0, 3);
                Piezas aux;
                aux = pieza[random];
                pieza[2] = pieza[random];
                pieza[random] = aux;

                reina.AtaqueFicha(tablero);//la reina la ponemos primero 
                for (int i = 0; i < 3; i++)
                { pieza[i].AtaqueFicha(tablero); }//todas las piezas atacan

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (tablero.tab[i, j] == 0)
                        {
                            cont++;//si hay alguna casilla en 0 no es solucion
                            break;
                        }
                    }

                }
                if (cont == 0)//chequeo que sea solucion 
                {
                     Console.WriteLine("se cubre todo el tablero");
                    for (int i = 0; i < 10; i++)
                    {
                        if (Vtable[i].tab == tablero.tab)
                        {
                            cont2++;//si ya existe ese tablero pongo contador en 1
                        }
                    }
                }
                if (cont2 == 0)//si cont2==0 es porque es una nueva solucion
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

     //public void OrdenAleatorio(Piezas[] pieza)
        //{
        //    Random rnd = new Random();
        //    int random = rnd.Next(0, 3);
        //    Piezas aux;
        //    aux = pieza[random];
        //    pieza[2] = pieza[random];
        //    pieza[random] = aux;


        //}