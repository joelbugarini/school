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
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

        public string NIP = "";

        private void Evaluar() {
            label1.Text = NIP;
            if (NIP.Length == 4) {
                if (NIP == "3568")
                {
                    MessageBox.Show("Retiro Permitido");
                }
                else
                {
                    MessageBox.Show("NIP Incorrecto");
                    NIP = "";
                }
            }
          
        }

        private void button1_Click(object sender, EventArgs e) { NIP += "1"; Evaluar(); }
        private void button2_Click(object sender, EventArgs e) { NIP += "2"; Evaluar(); }
        private void button3_Click(object sender, EventArgs e) { NIP += "3"; Evaluar(); }
        private void button4_Click(object sender, EventArgs e) { NIP += "4"; Evaluar(); }
        private void button5_Click(object sender, EventArgs e) { NIP += "5"; Evaluar(); }
        private void button6_Click(object sender, EventArgs e) { NIP += "6"; Evaluar(); }
        private void button7_Click(object sender, EventArgs e) { NIP += "7"; Evaluar(); }
        private void button8_Click(object sender, EventArgs e) { NIP += "8"; Evaluar(); }
        private void button9_Click(object sender, EventArgs e) { NIP += "9"; Evaluar(); }
        private void button10_Click(object sender, EventArgs e) { NIP += "0"; Evaluar(); }


        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            NIP = "";
            Evaluar();
        }
    }
}
