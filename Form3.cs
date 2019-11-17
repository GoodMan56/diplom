using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace diplom_test
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        public void button1_Click(object sender, EventArgs e)
        {
           
            Program.answers[0] = Convert.ToInt32(textBox1.Text);
            Program.answers[1] = Convert.ToInt32(textBox2.Text);
            Program.answers[2] = Convert.ToInt32(comboBox9.Text);
            Program.answers[3] = Convert.ToInt32(comboBox8.Text);
            Program.answers[4] = Convert.ToInt32(checkBox1.CheckState);
            Program.answers[5] = Convert.ToInt32(checkBox2.CheckState);
            Program.answers[6] = Convert.ToInt32(checkBox3.CheckState);


            Program.priority[0] = Convert.ToInt32(comboBox1.Text);
            Program.priority[1] = Convert.ToInt32(comboBox2.Text);
            Program.priority[2] = Convert.ToInt32(comboBox3.Text);
            Program.priority[3] = Convert.ToInt32(comboBox4.Text);
            Program.priority[4] = Convert.ToInt32(comboBox5.Text);
            Program.priority[5] = Convert.ToInt32(comboBox6.Text);
            Program.priority[6] = Convert.ToInt32(comboBox7.Text);

            Form6 f6 = new Form6();
            f6.Show(this);
            this.Hide();
         
        }
          
    }
}
