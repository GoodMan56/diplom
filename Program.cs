using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace diplom_test
{
    static class Program
    {
        /// <summary>
       static public SqlConnection sqlcon;
       static public int[] answers = new int[7];
       static public int[] priority = new int[7];
       static public int[ , ] A;
       static public double[] H;
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
