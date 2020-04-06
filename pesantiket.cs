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
    public partial class pesantiket : Form
    {
        public pesantiket()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_visprog";
            string query = "INSERT INTO bookings (src, dst, stime, loginid) VALUES ('" + (string)comboBox1.SelectedItem + "','" + (string)comboBox2.SelectedItem + "','" + (string)comboBox3.SelectedItem + "','" + textBox1.Text + "')";
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, dbcon);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                dbcon.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("BOOKING SUCCESS", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcon.Close();

                this.Hide();
              
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            profil pro = new profil();
            pro.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            beranda ber = new beranda();
            ber.Show();
        }
    }
}
