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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source = database.db; Version = 3"))
            {
                conn.Open();
                string comText = "INSERT INTO info (Name, Deyatelnost, Adress) VALUES (@com, @de, @ad)";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandText = comText;
                cmd.Parameters.AddWithValue("@com", textBox1.Text);
                cmd.Parameters.AddWithValue("@de", textBox2.Text);
                cmd.Parameters.AddWithValue("@ad", textBox3.Text);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Добавление прошло успешно");
                conn.Open();
            }
            this.Hide();
        }
    }
}
