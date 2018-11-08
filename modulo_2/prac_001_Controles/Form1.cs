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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Capturar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido " + txt_Nombre.Text);
            lbl_Resultado.Text = "Bienvenido " + txt_Nombre.Text +
                                           " " + txt_ApellidoPaterno.Text +
                                           " " + txt_ApellidoMaterno.Text;
        }
    }
}
