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
    public partial class Gato : Form
    {
        bool turno = true; // true = X turno; false = Y turno
        int ct = 0;

        public Gato()
        {
            InitializeComponent();
        }
        
        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // once a button is clicked from the X-O buttons
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turno)
            {
                b.Text = "X";
                b.BackgroundImage = Properties.Resources.X;

            }
            else
            {
                b.Text = "O";
                b.BackgroundImage = Properties.Resources.O;
            }
            turno = !turno;
            b.Enabled = false;
            ct++;

            revisarGanador();
        }

        // revisar si hay ganador
        private void revisarGanador()
        {
            bool hayGanador = false;

            // horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                hayGanador = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                hayGanador = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                hayGanador = true;
            }

            // vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                hayGanador = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                hayGanador = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                hayGanador = true;
            }

            // diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                hayGanador = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                hayGanador = true;
            }

            if (hayGanador)
            {
                deshabilitarBotones();

                string ganador = "";
                if (turno)
                {
                    ganador = "O";
                }
                else
                {
                    ganador = "X";
                }
                MessageBox.Show(ganador + " gana!", "Victoria!");
            }
            else    //empate
            {
                if (ct == 9)
                {
                    MessageBox.Show("Nadie gana!", "Empate!");
                }
            }
        }
        // deshabilitar botones cuando hay un ganador y cuando el boton se oprime
        private void deshabilitarBotones()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void nuevoJuego_Click(object sender, EventArgs e)
        {
            turno = true;
            ct = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackgroundImage = null;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
