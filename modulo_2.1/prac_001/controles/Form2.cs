using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controles
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txt_A.Text);
                double b = Convert.ToDouble(txt_B.Text);

                lbl_a_mas_b.Text = Convert.ToString(a + b);
                lbl_a_menos_b.Text = Convert.ToString(a - b);
                lbl_a_por_b.Text = Convert.ToString(a * b);
                lbl_a_entre_b.Text = Convert.ToString(a / b);
            }
            catch (Exception ex) {
                MessageBox.Show("Solo se permiten numeros");
                txt_A.Text = "";
                txt_B.Text = "";
            }
            
        }
    }
}
