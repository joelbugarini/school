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
    public partial class Convertir : Form
    {
        public Convertir()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double mts = Convert.ToDouble(txt_Metros.Text);

            lbl_Result.Text = "\n" + mts + " mts = " + mts * 1000 + " mm" +
                                "\n" + mts + " mts = " + mts * 100 + " cm" +
                                "\n" + mts + " mts = " + mts * 10 + " dm" +
                                "\n" + mts + " mts = " + mts * 0.001 + " km" +
                                "\n" + mts + " mts = " + mts * 39.3701 + " in" +
                                "\n" + mts + " mts = " + mts * 3.28084 + " ft" +
                                "\n" + mts + " mts = " + mts * 0.000621371 + " mile";
        }
    }
}
