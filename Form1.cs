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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string password = "", user = "", server = "";
                server = textBox3.Text;
                password = textBox2.Text;
                user = textBox1.Text;
                //server = "MY_NETBOOK";,2500
                //password = "Гость";Network Library=DBMSSOCN; 
                //user = "Гость";
                // Data Source = MY_NETBOOK; Initial Catalog = ЛПЗ1SQL; Integrated Security = True;
                try
                {
                    Program.sqlcon = new SqlConnection(@"Data Source=" + server + @";
                                Database=Arenda1;  
                                user ID=" + user + @";Password=" + password + ";");
                    Program.sqlcon.Open();
                    var f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                catch (Exception p)
                {

                    MessageBox.Show("Проверьте введенные данные");
                    MessageBox.Show(p.Message);
                }

                /*if (textBox1.Text.ToLower().Equals("admin") && textBox2.Text.ToLower().Equals("123456"))
                {
                    var f2 = new Form2();
                    f2.Show();
                    this.Hide();
 
                }
                else
                    MessageBox.Show(@"Неверные логин или пароль");*/
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
