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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = database.db; Version = 3");
            conn.Open();
            
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Squared";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adap = new SQLiteDataAdapter(command);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;

        }



        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kur.Form2 Form2 = new Kur.Form2();
            Form2.Show();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Kur.Form6 Form6 = new Kur.Form6();
            Form6.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = database.db; Version = 3");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Squared";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adap = new SQLiteDataAdapter(command);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запись удалена");
            SQLiteConnection conn = new SQLiteConnection("Data Source = database.db; Version = 3");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Squared WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            cmd.ExecuteNonQuery();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Kur.Form3 Form3 = new Kur.Form3();
            Form3.Show();
        }

        private void расчетПлощадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kur.Form6 Form6 = new Kur.Form6();
            Form6.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void информацияОКомпанияхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kur.Form7 Form7 = new Kur.Form7();
            Form7.Show();
        }
    }
}
