using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamRab_2021_03_03_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float[] a = new float[1000];
        int n;
        Random rand = new Random();

        private void button1_Click_1(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            textBox2.Clear();
            for (int i = 0; i < n; i++)
            {
                float temp = rand.Next(1, 99);
                a[i] = temp / 10;
                textBox2.Text = textBox2.Text + Convert.ToString(a[i]) + "\r\n";
            };
        }
    }
}
