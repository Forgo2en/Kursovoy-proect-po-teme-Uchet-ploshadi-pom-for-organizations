using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kur
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = database.db; Version = 3");
            conn.Open();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM info";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adap = new SQLiteDataAdapter(command);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kur.Form1 Form1 = new Kur.Form1();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kur.Form8 Form8 = new Kur.Form8();
            Form8.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = database.db; Version = 3");
            conn.Open();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM info";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adap = new SQLiteDataAdapter(command);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
