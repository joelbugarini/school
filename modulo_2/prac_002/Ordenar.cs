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
    public partial class Ordenar : Form
    {
        public Ordenar()
        {
            InitializeComponent();
        }

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_numero1.Text);
            int b = Convert.ToInt32(txt_numero2.Text);
            int c = Convert.ToInt32(txt_numero3.Text);

            if (a > b)
            {
                if (b > c)
                {
                    lbl_Resultado.Text = a +", "+ b + ", " + c;
                }
                else
                {
                    lbl_Resultado.Text = a + ", " + c + ", " + b;
                }
            }
            else
            {
                if (a > c)
                {
                    lbl_Resultado.Text = b + ", " + c + ", " + a;
                }
                else
                {
                    lbl_Resultado.Text = c + ", " + b + ", " + a;
                }
            }
        }
    }
}
