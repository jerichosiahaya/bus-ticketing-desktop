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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string session = textBox1.Text;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_visprog";
            /* string query = "INSERT INTO login VALUES ('"+textBox1.Text+"','"+textBox2.Text+"')"; */
            string query = "SELECT * FROM login WHERE loginid = '" + textBox1.Text + "' AND pass = '" + textBox2.Text + "'";
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, dbcon);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            dbcon.Open();
            reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                this.Hide();
                beranda f2 = new beranda();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Maaf, kamu salah memasukkan username atau password");
            }
            /*
            try
            {
                dbcon.Open();
                reader = commandDatabase.ExecuteReader();
                Class1.location = textBox1.Text;
                MessageBox.Show("LOGIN SUCCESS");

                dbcon.Close();
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
