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
    public partial class Form5 : Form
    {
        public Form5(Tablero[] vtab)
        {
            InitializeComponent();
            
            for (int i = 0; i < 9; i++)
            {   
                //dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Rows.Insert(0, vtab[i].tab[0, 0], vtab[i].tab[0, 1], vtab[i].tab[0, 2], vtab[i].tab[0, 3], vtab[i].tab[0, 4], vtab[i].tab[0, 5], vtab[i].tab[0, 6], vtab[i].tab[0, 7]);
                dataGridView1.Rows.Insert(1, vtab[i].tab[1, 0], vtab[i].tab[1, 1], vtab[i].tab[1, 2], vtab[i].tab[1, 3], vtab[i].tab[1, 4], vtab[i].tab[1, 5], vtab[i].tab[1, 6], vtab[i].tab[1, 7]);
                dataGridView1.Rows.Insert(2, vtab[i].tab[2, 0], vtab[i].tab[2, 1], vtab[i].tab[2, 2], vtab[i].tab[2, 3], vtab[i].tab[2, 4], vtab[i].tab[2, 5], vtab[i].tab[2, 6], vtab[i].tab[2, 7]);
                dataGridView1.Rows.Insert(3, vtab[i].tab[3, 0], vtab[i].tab[3, 1], vtab[i].tab[3, 2], vtab[i].tab[3, 3], vtab[i].tab[3, 4], vtab[i].tab[3, 5], vtab[i].tab[3, 6], vtab[i].tab[3, 7]);
                dataGridView1.Rows.Insert(4, vtab[i].tab[4, 0], vtab[i].tab[4, 1], vtab[i].tab[4, 2], vtab[i].tab[4, 3], vtab[i].tab[4, 4], vtab[i].tab[4, 5], vtab[i].tab[4, 6], vtab[i].tab[4, 7]);
                dataGridView1.Rows.Insert(5, vtab[i].tab[5, 0], vtab[i].tab[5, 1], vtab[i].tab[5, 2], vtab[i].tab[5, 3], vtab[i].tab[5, 4], vtab[i].tab[5, 5], vtab[i].tab[5, 6], vtab[i].tab[5, 7]);
                dataGridView1.Rows.Insert(6, vtab[i].tab[6, 0], vtab[i].tab[6, 1], vtab[i].tab[6, 2], vtab[i].tab[6, 3], vtab[i].tab[6, 4], vtab[i].tab[6, 5], vtab[i].tab[6, 6], vtab[i].tab[6, 7]);
                dataGridView1.Rows.Insert(7, vtab[i].tab[7, 0], vtab[i].tab[7, 1], vtab[i].tab[7, 2], vtab[i].tab[7, 3], vtab[i].tab[7, 4], vtab[i].tab[7, 5], vtab[i].tab[7, 6], vtab[i].tab[7, 7]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
