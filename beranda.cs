using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class beranda : Form
    {
        public beranda()
        {
            InitializeComponent();
        }
    
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lihattiket f4 = new lihattiket();
            f4.Show();
           
            }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pesantiket f = new pesantiket();
            f.Show();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lihatjadwal f5 = new lihatjadwal();
            f5.Show();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            profil pro = new profil();
            pro.Show();
        }
    }
}
