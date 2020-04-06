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
    public partial class lihattiket : Form
    {
        public lihattiket()
        {
            InitializeComponent();
        }
        public string usr = Class1.location;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            login f1 = new login();
            string userName = f1.textBox1.Text;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_visprog";
            string query = "SELECT src, dst, stime FROM bookings WHERE loginid = '" + userName + "'";
            /* string query = "SELECT src, dst, stime FROM bookings";*/
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, dbcon);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                dbcon.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem lst = new ListViewItem(reader.GetString(0).ToString());
                        lst.SubItems.Add(reader.GetString(1));
                        lst.SubItems.Add(reader.GetString(2));
                        listView1.Items.Add(lst);
                    }
                    reader.Close();
                    dbcon.Close();
                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
            label1.Text = usr;
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Source", 100);
            listView1.Columns.Add("Destination", 100);
            listView1.Columns.Add("Time", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            beranda f2 = new beranda();
            f2.Show();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            profil pro = new profil();
            pro.Show();
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            beranda ber = new beranda();
            ber.Show();
        }

        private void uBusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lihattiket_Load(object sender, EventArgs e)
        {
           // label2.Text = usr;
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Source", 100);
            listView1.Columns.Add("Destination", 100);
            listView1.Columns.Add("Time", 100);
            // string userName = f1.textBox1.Text;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_visprog";
            /*  string query = "SELECT src, dst, stime FROM bookings WHERE loginid = '" + userName + "'"; */
            string query = "SELECT src, dst, stime FROM bookings";
            MySqlConnection dbcon = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, dbcon);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                dbcon.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem lst = new ListViewItem(reader.GetString(0).ToString());
                        lst.SubItems.Add(reader.GetString(1));
                        lst.SubItems.Add(reader.GetString(2));
                        listView1.Items.Add(lst);
                    }
                    reader.Close();
                    dbcon.Close();
                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }
    }
}

