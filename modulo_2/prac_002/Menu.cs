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
    public partial class Menu : Form
    {

        public Menu()
        {            
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {

            string[,] Usuarios = {
                { "Joel", "1234", "joel@me.com" },
                { "Martin", "1234","martin@me.com" },
                { "Abel", "1234", "abel@me.com" },
                { "Roman", "1234", "roman@me.com" }
            };

            for (int i = 0; i < Usuarios.GetLength(0); i++)
            {
                string nombre = Usuarios[i, 0];
                string pass = Usuarios[i, 1];
                string email = Usuarios[i, 2];

                dataGridView1.Rows.Add(nombre, pass, email);
                
            }
        }
        
    }
}
