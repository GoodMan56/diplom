using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom_test
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.H.Length <= 1)
            {
                MessageBox.Show("Подходящих помещений не найдено");
                return;
            }
            label1.Text = "";
            double[] D = new double[Program.H.Length];
            for(int i = 0; i < Program.H.Length; i++){
                label1.Text += Program.H[i].ToString("F3") + "   ";
                D[i] = Program.H[i] - Program.H[Program.H.Length - 1];
            }
            int left = -1, right = -1;
            double tmax = Int32.MinValue, tmin = Int32.MaxValue;
            for (int j = 0; j < Program.H.Length - 1; j++)
            {
                if (D[j] > tmax && D[j] <= 0) {
                    tmax = D[j];
                    left = j;
                }

                if (D[j] < tmin && D[j] > 0)
                {
                    tmin = D[j];
                    right = j;
                }
            }
           label2.Text = "Наиболее подходящие помещения: ";
            if (left != -1 ) {
                double t = Program.H[Program.H.Length - 1] / Program.H[left];
                if (t < 0.95 || t > 1.05)
                    left = -1;
                else label2.Text += "# " + (left+2001).ToString() + " ";
            }
            if (right != -1)
            {
                double t = Program.H[Program.H.Length - 1] / Program.H[right];
                if (t < 0.95 || t > 1.05)
                    right = -1;
                else label2.Text += "# " + (right+2001).ToString() + " ";
            }
            if (left == -1 && right == -1)
            {
                MessageBox.Show("Подходящих помещений не найдено");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
