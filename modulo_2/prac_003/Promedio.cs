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
            try
            {
                numeros[contador] = Convert.ToDouble(txt_numero.Text);

                contador++;
                lbl_captura.Text = "Ingrese el numero " + (contador + 1) + ":";
                txt_numero.Clear();
                txt_numero.Focus();


                if (contador + 1 == 16)
                {
                    lbl_Mayor.Text = "Mayor: " + numeros.Max();
                    lbl_Menor.Text = "Menor: " + numeros.Min();
                    lbl_Suma.Text = "Suma: " + numeros.Sum();
                    lbl_Promedio.Text = "Promedio: " + numeros.Average();
                    txt_numero.ReadOnly = true;
                    btn_capturar.Enabled = false;

                    for (int n = 0; n < 15; n++)
                    {
                        lbl_Matriz.Text += "Matriz [" + n + "] = " + numeros[n] + Environment.NewLine;
                    }
                }
            }
            catch {
                MessageBox.Show("Solo numero bebe de luz");
                txt_numero.Text = "";
                txt_numero.Focus();
            }
            
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            contador = 0;
            txt_numero.ReadOnly = false;
            btn_capturar.Enabled = true;
            numeros = new double[15];
            lbl_Matriz.Text = "";
            lbl_captura.Text = "Ingrese el numero 1:";
            lbl_Mayor.Text = "Mayor: ";
            lbl_Menor.Text = "Menor: ";
            lbl_Suma.Text = "Suma: ";
            lbl_Promedio.Text = "Promedio: ";
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (contador < 15)
                if (e.KeyChar == (char)Keys.Return) btn_capturar_Click(sender, e);
        }
    }
}
