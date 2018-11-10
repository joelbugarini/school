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
    public partial class Farenheit : Form
    {
        public Farenheit()
        {
            InitializeComponent();
        }

        private void btn_Centigrados_Click(object sender, EventArgs e)
        {
            double grados = Convert.ToDouble(txt_Centigrados.Text);
            lbl_Centrigrados.Text = ((grados * (9.0 / 5.0)) + 32).ToString();
        }

        private void btn_Farenheit_Click(object sender, EventArgs e)
        {
            double grados = Convert.ToDouble(txt_Farenheit.Text);
            lbl_Farenheit.Text = ((grados - 32) * (5.0 / 9.0)).ToString();
        }
    }
}
