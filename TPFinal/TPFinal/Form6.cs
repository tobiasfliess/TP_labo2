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
        public Form6(Tablero vtable)
        {
            InitializeComponent();
            bool bcaballo = false;
            bool btorre = false;
            bool balfil = false;

            Point[,] matriz = new Point[8, 8];
            matriz[0, 0] = Alfil1.Location;
            matriz[0, 1] = Alfil2.Location;
            matriz[1, 0] = Caballo1.Location;

            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (vtable.tab[j, k] == 2)
                    {
                        Reina.Location = new Point(151 + (j * 47), 26 + (k * 50));
                        //Reina.Location.X = 202 + j * 63;
                        //Reina.Location.Y = 33 + k * 63;
                    }

                    if (vtable.tab[j, k] == 3)
                    {
                        Rey.Location = new Point(151 + (j * 47), 26 + (k * 50));

                    }
                    if (vtable.tab[j, k] == 4)
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
                    if (vtable.tab[j, k] == 5)
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

                    if (vtable.tab[j, k] == 6)
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
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }
    }
}
