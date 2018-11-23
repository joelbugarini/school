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
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        public string[,] data = {{ "JXJN737412UL1", "Gary", "Schmidt", "Franks" },
                    { "RDFE192563OW2", "Quinlan", "Solis", "Huffman" },
                    { "WBVA891445TN9", "Kennedy", "Joyner", "Byrd" },
                    { "LFLW852561UT3", "Samson", "Francis", "Harding" },
                    { "WZWY789913KO3", "Alea", "Schroeder", "Gates" },
                    { "HJVH356471LA1", "Lionel", "Thomas", "Pierce" },
                    { "TFBX252687OB7", "Warren", "Fitzgerald", "Leblanc" },
                    { "LQAJ385988XA2", "Galvin", "Guzman", "Oneill" },
                    { "EHXC544731EB4", "Alvin", "Cantrell", "Downs" },
                    { "MURL281441ZF5", "Tyrone", "Burch", "Compton" },
                    { "IXOJ643775SQ6", "Regan", "Cruz", "Kidd" },
                    { "MSRO774879OG9", "Melyssa", "Mcmillan", "Dickson" },
                    { "ZDIS598632LD1", "Lacota", "Raymond", "Alvarado" },
                    { "TRBO157248SE6", "MacKenzie", "Carr", "Mcmahon" },
                    { "BATJ795592GP7", "Eagan", "Bullock", "Alford" },
                    { "PYXM643194MX4", "Amena", "Cantu", "Holman" } };
        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            rtx_Resultado.Text = "";
            var renglones = data.GetUpperBound(0) +1;
            var columnas = data.GetUpperBound(1) +1;

            for (int renglon = 0; renglon < renglones; renglon++)
            {
                bool encontrado = false;
                for (int columna = 0; columna < columnas; columna++)
                {
                    if (!encontrado)
                    {
                        if (data[renglon, columna].ToLower().Contains(txt_Texto.Text.ToLower()))
                        {
                            encontrado = true;
                            rtx_Resultado.Text += data[renglon, 0] + " " + 
                                                  data[renglon, 1] + " " + 
                                                  data[renglon, 2] + " " +
                                                  data[renglon, 3] + "\n";
                        }
                    }
                }
            }

        }
    }
}
