using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_002
{
    public partial class Formula : Form
    {
        public Formula()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);
            int c = Convert.ToInt32(txt_c.Text);

            double sqrtpart = (b * b) - (4 * a * c);
            double x1 = ((-1) * b + Math.Sqrt(sqrtpart)) / (2 * a);
            double x2 = ((-1) * b - Math.Sqrt(sqrtpart)) / (2 * a);

            lbl_x1.Text = x1.ToString();
            lbl_x2.Text = x2.ToString();
        }
    }
}
