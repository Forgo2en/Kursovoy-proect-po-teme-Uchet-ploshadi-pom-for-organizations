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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source = database.db; Version = 3"))
            {
                conn.Open();
                string comText = "INSERT INTO Squared (Company, Square) VALUES (@com, @sq)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandText = comText;
                cmd.Parameters.AddWithValue("@com", textBox1.Text);
                cmd.Parameters.AddWithValue("@sq", textBox8.Text);
                textBox1.Clear();
                textBox2.Clear();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Добавление прошло успешно");
                conn.Open();
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double q = double.Parse(textBox2.Text);
            double w = double.Parse(textBox3.Text);
            double r = double.Parse(textBox4.Text);
            double t = double.Parse(textBox5.Text);
            double y = double.Parse(textBox6.Text);
            double u = double.Parse(textBox7.Text);
            double x = 0;
            x = (q * w) + (r * t) + (y * u);
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Text += Environment.NewLine + x.ToString();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Kur.Form1 Form1 = new Kur.Form1();
            Form1.Show();
        }
    }
}
