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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arenda1DataSet.Договор_аренды". При необходимости она может быть перемещена или удалена.
            this.договор_арендыTableAdapter.Fill(this.arenda1DataSet.Договор_аренды);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arenda1DataSet.Помещение". При необходимости она может быть перемещена или удалена.
            this.помещениеTableAdapter.Fill(this.arenda1DataSet.Помещение);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
