using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Reina =2
//Rey = 3
//Caballo =4
//Torre =5
//Alfil =6

namespace TPFinal
{
    public partial class FPrincipal : Form
    {
        static int Contador_Soluciones = 0; 


        public FPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            int Cantidad_Soluciones = 10; 

            Tablero tablero = new Tablero(); 
            Reina reina = new Reina(); 
            Rey rey = new Rey(); 
            Caballo caballo = new Caballo(); 
            Torre torre = new Torre(); 
            Alfil alfil = new Alfil(); 

            Tablero auxtab = new Tablero();
            auxtab.IniciarTablero();
            Tablero auxtab2 = new Tablero();
            auxtab2.IniciarTablero();
            Tablero auxtab3 = new Tablero();
            auxtab3.IniciarTablero();
            Tablero auxtab4 = new Tablero();
            auxtab4.IniciarTablero();
            Tablero auxtab5 = new Tablero();
            auxtab5.IniciarTablero(); 
            Tablero auxtab6 = new Tablero();
            auxtab6.IniciarTablero();
            Tablero auxtab7 = new Tablero();
            auxtab7.IniciarTablero();
            Tablero auxtab8 = new Tablero();
            auxtab.IniciarTablero();
            Tablero auxtab9 = new Tablero();
            auxtab.IniciarTablero();
            Tablero auxtab10 = new Tablero();
            auxtab10.IniciarTablero();

            Tablero[] Vtable = new Tablero[10];
            
            Vtable[0] = auxtab;
            Vtable[1] = auxtab2;
            Vtable[2] = auxtab3;
            Vtable[3] = auxtab4;
            Vtable[4] = auxtab5;
            Vtable[5] = auxtab6;
            Vtable[6] = auxtab7;
            Vtable[7] = auxtab8;
            Vtable[8] = auxtab9;
            Vtable[9] = auxtab10;


            tablero.IniciarTablero();

            Piezas[] pieza = new Piezas[7];
            pieza[6] = rey;
            pieza[5] = caballo;
            pieza[4] = caballo;
            pieza[3] = torre;
            pieza[2] = torre;
            pieza[1] = alfil;
            pieza[0] = alfil;

            // OrdenAleatorio(pieza);

            //5*(12+2n+24n^2+8n+6+39n^3+72n^2+6n+1+4*(39n^3+168n^2+14n+2)+64n^2+2n) = 5*(39n^3+160n^2+18n+17+156n^3+672n^2+56n+8) = 5*(195n^3+832n^2+74n+25)=975n
            while (Contador_Soluciones != Cantidad_Soluciones && Contador_Soluciones < 10) //5*
            {
                Random rnd = new Random(); //1
                int random = rnd.Next(0, 6); //1
                Piezas aux;
                aux = pieza[2]; //1
                pieza[2] = pieza[random]; //3
                pieza[random] = aux; //3

                tablero = reina.AtaqueFicha(tablero); //3
                for (int i = 0; i < 7; i++) // n*
                { tablero = pieza[i].AtaqueFicha(tablero); //2

                }

                Verificar(Vtable, tablero);//24n ^ 2 + 8n + 6

                Rotar(Vtable, tablero); //39n ^ 3 + 72n ^ 2 + 6n + 1
                if (CBRotar.Checked == true){ // 2
                    EspejadoHorizontal(Vtable, tablero);// 39n ^ 3 + 168n ^ 2 + 14n + 2
                    EspejadoVertical(Vtable, tablero);//39n^3+168n^2+14n+2
                }
                tablero.IniciarTablero(); //64n^2

            }

            for (int i = 0; i < 10; i++) ///n*
            {
                Form6 mostrar = new Form6(Vtable[i]); //2
                mostrar.Show();
                this.Hide();
            }
        }
        void Rotar(Tablero[] vTab, Tablero tab) //1+64n^2+7n^2+n(15n^2+24n ^ 2 + 8n + 6) = 39n^3+72n^2+6n+1
        {
            Tablero tabaux = new Tablero(); // 1
            tabaux.IniciarTablero(); //64n^2
            for (int k = 0; k < 8; k++) //n*
            {
                for (int l = 0; l < 8; l++)//n*  //copiamos asi la matriz a la auxiliar para que no se pase como parametro sino que se copien los valores
                    {
                     tabaux.tab[k, l] = tab.tab[k, l];//7
                    }
            }
            int aux;

            for (int p = 0; p < 3; p++)//n
            {
                for (int i = 0; i < 8; i++)//n
                {
                    for (int j = 0; j < 8; j++)//n
                    {

                        aux = tabaux.tab[i, j];//2
                        tabaux.tab[i, j] = tabaux.tab[j, 7 - i];//8
                        tabaux.tab[j, 7 - i] = aux;//5
                    }
                }
                Verificar(vTab, tabaux); //24n ^ 2 + 8n + 6

            }
            return;
        }
        void EspejadoHorizontal(Tablero[] vTab, Tablero Tab) // 1+64n^2+8n^2+24n^2+8n+6+39n^3+72n^2+6n+1 = 39n^3+168n^2+14n+2
        {
            Tablero tabaux = new Tablero(); //1
            tabaux.IniciarTablero(); //64n^2

            for (int i = 0; i < 8; i++)//n
            {
                for (int j = 0; j < 4; j++)// va del 0-3 y los espeja con 4-7  n
                {
                    tabaux.tab[i, 7 - j] = Tab.tab[i, j]; // 8
                }
            }
            Verificar(vTab, tabaux);// 24n^2+8n+6
            Rotar(vTab, tabaux); //39n ^ 3 + 72n ^ 2 + 6n + 1
            return;
        }
        void EspejadoVertical(Tablero[] vTab, Tablero Tab) //=horiz
        {
            Tablero tabaux = new Tablero(); 
            tabaux.IniciarTablero(); 

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)// va del 0-3 y los espeja con 4-7
                {
                    tabaux.tab[7 - i, j] = Tab.tab[i, j];
                }
            }
            Verificar(vTab, tabaux);//24n^2+8n+6
            Rotar(vTab, tabaux);
            return;
        }

        static void Verificar(Tablero[] Vtab, Tablero tab) // 2 +1+1+4n^2+8n+20n^2+2 = 24n^2+8n+6
        {
            if (Contador_Soluciones > 9) //2
                return;
            int cont = 0; //1
            int cont2 = 0;//1
            for (int i = 0; i < 8; i++)//n
            {
                for (int j = 0; j < 8; j++)//n
                {
                    if (tab.tab[i, j] == 0)//3
                    {
                        cont++;//1
                        return;
                    }
                }

            }
            if (cont == 0)//2
            {
                for (int i = 0; i < 9; i++)//n
                {
                    if (Vtab[i].tab == tab.tab)//3
                    {
                        cont2++;//1
                    }
                }
            }
            if (cont2 == 0)//2
            {
                for (int k = 0; k < 8; k++)//n
                {
                    for (int l = 0; l < 8; l++)//n
                    {
                       Vtab[Contador_Soluciones].tab[k, l] = tab.tab[k, l];//7
                    }
                }
                Contador_Soluciones++;//1
                tab.Imprimir(); //3n^2
            }
            return;
        }
        private void btnCosto_Click(object sender, EventArgs e)
        {
            costo costo = new costo();
            costo.Show();

        }

    }
}
