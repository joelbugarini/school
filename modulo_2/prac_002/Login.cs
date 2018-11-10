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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "Joel" && txt_pass.Text == "1234")
            {
                MessageBox.Show("Bienvenido!");
            }
            else {
                MessageBox.Show("Contraseña o usuario incorrecto");
            }
        }
    }
}
