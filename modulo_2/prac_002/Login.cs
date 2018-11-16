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
                this.Hide();
                new Menu().ShowDialog();
                txt_pass.Text = "";
                txt_user.Text = "";
                this.Show();
            }
            else {
                txt_pass.Text = "";
                txt_user.Text = "";

                MessageBox.Show("Contraseña o usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_user.Focus();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
