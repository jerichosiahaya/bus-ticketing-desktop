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
    public partial class lihatjadwal : Form
    {
        public lihatjadwal()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {

           
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_visprog";
            string query = "select * from jadwal;";
            MySqlConnection MyConn2 = new MySqlConnection(connectionString);
            MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            profil pro = new profil();
            pro.Show();
        }

        private void berandaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            beranda f2 = new beranda();
            f2.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
