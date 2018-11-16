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
    public partial class Extraordinario : Form
    {
        public Extraordinario()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int reprobadas = Convert.ToInt32(txt_materias.Text);

            
            if (reprobadas >= 3) lbl_resultado.Text = "Sin derecho a extraordinario";
            if (reprobadas < 3) lbl_resultado.Text = "Con derecho a extraordinario";
            if (reprobadas == 0) lbl_resultado.Text = "Alumno regular";
            if (reprobadas >= 8) lbl_resultado.Text = "NO MACAYU";

        }
    }
}
