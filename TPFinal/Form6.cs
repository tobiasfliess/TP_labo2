using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    public partial class Form6 : Form
    {
        static bool siguiente;
        static bool anterior;
        static int i = 0;
        
        Tablero[] aux;
        int p;
     
        public Form6(Tablero[] vtable,int Cant)
        {   
            InitializeComponent();
            aux= vtable;
            p= Cant;
            Colocar(vtable);
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Tablero_Click(object sender, EventArgs e)
        {

        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            i++;
            if (i > p-1)
                i = 0;
            Colocar(aux);
            
            
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            
            i--;
            if (i < 0)
                i = p-1;
             Colocar(aux);
        }

        private void Salir_Click(object sender, EventArgs e)
        {   
          
            Application.Exit();
           
        }
        
      

        private void Colocar(Tablero[] vtable)
        {
            bool bcaballo = false;
            bool btorre = false;
            bool balfil = false;

            
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (vtable[i].tab[j, k] == 2)
                        {
                            Reina.Location = new Point(151 + (j * 47), 26 + (k * 50));
                        }

                        if (vtable[i].tab[j, k] == 3)
                        {
                            Rey.Location = new Point(151 + (j * 47), 26 + (k * 50));

                        }
                        if (vtable[i].tab[j, k] == 4)
                        {
                            if (bcaballo == true)
                            {
                                Caballo2.Location = new Point(151 + (j * 47), 26 + (k * 50));

                            }

                            if (bcaballo == false)
                            {
                                Caballo1.Location = new Point(151 + (j * 47), 26 + (k * 50));
                                bcaballo = true;
                            }
                        }
                        if (vtable[i].tab[j, k] == 5)
                        {
                            if (btorre == true)
                            {
                                Torre2.Location = new Point(151 + (j * 47), 26 + (k * 50));

                            }

                            if (btorre == false)
                            {
                                Torre1.Location = new Point(151 + (j * 47), 26 + (k * 50));
                                btorre = true;
                            }
                        }

                        if (vtable[i].tab[j, k] == 6)
                        {
                            if (balfil == true)
                            {
                                Alfil2.Location = new Point(151 + (j * 47), 26 + (k * 50));
                            }

                            if (balfil == false)
                            {
                                Alfil1.Location = new Point(151 + (j * 47), 26 + (k * 50));
                                balfil = true;
                            }
                        }
                    }
                }       
                this.Show();
        }
    }
}
