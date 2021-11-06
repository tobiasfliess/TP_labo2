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
    public partial class FTablero : Form
    {
        public FTablero(Tablero[] vtable)
        {
            InitializeComponent();

        }
        int x = 100;
        int y = 50;
        string strButtonName = "btn_Tablero";
        private void FTablero_Load(object sender, EventArgs e)
        {
            int nBoton = 0; //Almaceno el numero de boton
            for (int i = 1; i <= 10; i++)
            {
                nBoton++; //Para dessincronizarlos, le sumo 1 al cambiar de fila
                for (int j = 1; j <= 10; j++)
                {
                    var btn = new Button();
                    btn.Text = "";
                    btn.Name = string.Format("{0}_{1}", strButtonName, nBoton); // Le doy un name que me permita identificar el boton
                    btn.Tag = nBoton; // Le añado un tag, para permitirme ordenarlos
                    btn.Location = new Point(x, y);
                    btn.Size = new Size(50, 50);


                    this.Controls.Add(btn);
                    x += 50;
                    nBoton++;
                }

                y += 50;
                x = 100;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var btn in this.Controls.OfType<Button>().Where(x => x.Name.Contains(strButtonName)))  //Busco los controles de tipo button que tengan en el name el texto que he indicado
            {
                btn.BackColor = Convert.ToInt32(btn.Tag) % 2 == 0 ? Color.White : Color.Black; //Loas ares de un color, los impares de otro
            }
        }
    }
}
