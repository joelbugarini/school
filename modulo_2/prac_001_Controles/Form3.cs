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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Comparar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txt_Numero1.Text);
                double num2 = Convert.ToDouble(txt_Numero2.Text);

                if (num1 == num2) lbl_Resultado.Text = "Son iguales";
                if (num1 < num2) lbl_Resultado.Text = "Numero dos es mayor";
                if (num1 > num2) lbl_Resultado.Text = "Numero uno es mayor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo numeros");
                txt_Numero1.Text = "";
                txt_Numero2.Text = "";
            }
        }
    }
}
