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
    public partial class Tabla : Form
    {
        public Tabla()
        {
            InitializeComponent();
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txt_numero.Text);

            rtx_Resultado.Text = "";
            rtx_Resultado.Text += numero + " x 1 = " + numero * 1 + "\n";
            rtx_Resultado.Text += numero + " x 2 = " + numero * 2 + "\n";
            rtx_Resultado.Text += numero + " x 3 = " + numero * 3 + "\n";
            rtx_Resultado.Text += numero + " x 4 = " + numero * 4 + "\n";
            rtx_Resultado.Text += numero + " x 5 = " + numero * 5 + "\n";
            rtx_Resultado.Text += numero + " x 6 = " + numero * 6 + "\n";
            rtx_Resultado.Text += numero + " x 7 = " + numero * 7 + "\n";
            rtx_Resultado.Text += numero + " x 8 = " + numero * 8 + "\n";
            rtx_Resultado.Text += numero + " x 9 = " + numero * 9 + "\n";
            rtx_Resultado.Text += numero + " x 10 = " + numero * 10 + "\n";
        }
    }
}
