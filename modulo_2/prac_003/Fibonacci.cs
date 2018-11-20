using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_003
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }
               

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            long lim = Convert.ToInt64(txt_Limite.Text);
            for (int i = 0; sum(i) < lim; i++)
            {
                lbl_Result.Text += sum(i);
                if (sum(i + 1) <= lim) lbl_Result.Text += ",";
            }
        }

        static long sum(long n)
        {
            long a = 0;
            long b = 1;

            for (long i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
