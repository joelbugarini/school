using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_005
{
    public partial class Nombre : Form
    {
        public Nombre()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Joel Bugarini";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "28";
        }
    }
}
