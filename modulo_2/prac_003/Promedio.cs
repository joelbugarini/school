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
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }

        public double[] numeros = new double[15];
        public int contador = 0;

        private void btn_capturar_Click(object sender, EventArgs e)
        {
            
            numeros[contador] = Convert.ToDouble(txt_numero.Text);
            contador++;
            lbl_captura.Text = "Ingrese el numero " + (contador + 1) + ":";
            txt_numero.Clear();
            txt_numero.Focus();

            if (contador+1 == 15)
                lbl_resultado.Text = "El promedio es: " + numeros.Average();
            
        }
    }
}
