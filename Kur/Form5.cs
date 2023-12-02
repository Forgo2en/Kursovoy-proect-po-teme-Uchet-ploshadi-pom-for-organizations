using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kur
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kur.Form1 Form1 = new Kur.Form1();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kur.Form2 Form2 = new Kur.Form2();
            Form2.Show();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Kur.Form3 Form3 = new Kur.Form3();
            Form3.Show();
        }
    }
}
