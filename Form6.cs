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
    public partial class Form6 : Form
    {

        double Rinc, Rdec;
        int xij, xmax, xmin, str, maxC, maxP, maxS, maxK;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
          

            // TODO: данная строка кода позволяет загрузить данные в таблицу "arenda1DataSet.Характеристика_помещения". При необходимости она может быть перемещена или удалена.
              this.характеристика_помещенияTableAdapter.Fill(this.arenda1DataSet.Характеристика_помещения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arenda1DataSet.Помещение". При необходимости она может быть перемещена или удалена.
           // this.помещениеTableAdapter.Fill(this.arenda1DataSet.Помещение);

            int str = dataGridView1.RowCount; 
      //      dataGridView1.Rows[3].Cells[3].Value = "50";

            Program.A = new int[7, str];
            for (int i = 0; i < 7; i++) {
                for (int j = 0; j < str; j++)
                {
                    Program.A[i, j] = Convert.ToInt32(dataGridView1.Rows[j].Cells[i].Value);        
                }
                Program.A[i, str - 1] = Program.answers[i];
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int str = dataGridView1.RowCount;
            double[ , ] R = new double[7, str];
            double[] P5 = new double[7];
            double[,] Pr = new double[7, str];
            double Psum = 0;
            double[] F = new double[7];
           
            for (int i = 0; i < 7; i++)
            {
                int tmax = Int32.MinValue, tmin = Int32.MaxValue;
                for (int j = 0; j < str; j++)
                {
                    if (Program.A[i, j] > tmax)
                        tmax = Program.A[i, j];
                    if (Program.A[i, j] < tmin)
                        tmin = Program.A[i, j];
                }
                for (int j = 0; j < str; j++) {
                    if (i == 0)
                    {
                        R[i, j] = (tmax - Program.A[i, j] + 0.0001) / (tmax - tmin);
                    }
                    else {
                        R[i, j] = (Program.A[i, j] - tmin + 0.0001) / (tmax - tmin);
                    }
                  
                }
                double rsum = 0;
                for (int j = 0; j < str; j++) {
                    rsum += R[i, j];
                }
                for (int j = 0; j < str; j++) {  
                    Pr[i, j] = R[i,j]/rsum;
                }
                F[i] = 2 * (7 - Program.priority[i] + 1.0) / (7 * (7 + 1));
                P5[i] = F[i] * rsum;
                Psum += P5[i];
            }
            for (int i = 0; i < 7; i++){
                P5[i] /= Psum;
            }
            Program.H = new double[str];
            for (int j = 0; j < str; j++) {
                Program.H[j] = 0;
                for (int i = 0; i < 7; i++){
                    Program.H[j] += F[i] * Pr[i, j];
                }

            }

            for (int j = 0; j < str; j++)
            {

                for (int i = 0; i < 7; i++)
                {
                    Pr[i, j] = (Pr[i, j] * F[i]) / (Program.H[j]);
                }
            }
            for (int j = 0; j < str; j++){ 
                 Program.H[j] = 0;
                for (int i = 0; i < 7; i++){
                    Program.H[j] += -(Pr[i, j] * Math.Log10(Pr[i, j]));
                }
                
            }
           
            Form7 f7 = new Form7();
            f7.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        
    }
}




/*SqlCommand myCom = Program.sqlcon.CreateCommand();
            SqlDataAdapter adapter;
            DataSet ds;
            myCom.CommandText =
               @"
SELECT Max([Характеристика помещения].Цена) AS [Max-Цена], Max([Характеристика помещения].Площадь) AS [Max-Площадь], Max([Характеристика помещения].Состояние) AS [Max-Состояние], Max([Характеристика помещения].[Наличие комуникаций]) AS [Max-Наличие комуникаций]
FROM [Характеристика помещения]
WHERE ((([Max-Цена])=(@start1))
AND (([Max-Площадь])=(@start2))
AND (([Max-Состояние])=(@start3))
AND (([Max-Наличие комуникаций])=(@start4)));
            ";

            myCom.Parameters.AddWithValue("@start1", maxC);
            myCom.Parameters.AddWithValue("@start2", maxP);
            myCom.Parameters.AddWithValue("@start3", maxS);
            myCom.Parameters.AddWithValue("@start4", maxK);
            adapter = new SqlDataAdapter(myCom);
            ds = new DataSet();
            adapter.Fill(ds);*/