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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source = database.db; Version = 3"))
            {
                conn.Open();
                string comText = "SELECT * FROM Users WHERE Name = @log AND Pass = @pass";
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = conn;
                command.CommandText = comText;
                command.Parameters.AddWithValue("@log", textBox1.Text);
                command.Parameters.AddWithValue("@pass", textBox2.Text);
                command.ExecuteNonQuery();
                DataTable a = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(a);
                if(a.Rows.Count > 0)
                {
                    this.Hide();
                    Kur.Form5 Form5 = new Kur.Form5();
                    Form5.Show();
                }
                else
                {
                    MessageBox.Show("QQha poehala");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kur.Form4 Form4 = new Kur.Form4();
            Form4.Show();
        }
    }
}
