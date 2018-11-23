using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preac_004
{
    public partial class Letras : Form
    {
        public Letras()
        {
            InitializeComponent();
        }

        private void btn_InvertirClick(object sender, EventArgs e)
        {            
            string n = textBox1.Text;
            if (n.Length == 11)
                lbl_resultado.Text = n[10].ToString() + n[8].ToString() + n[5].ToString() + n[3].ToString() + n[0].ToString();
            else
                MessageBox.Show("Deben ser 11 letras, pusiste " + n.Length);
        }
    }
}
