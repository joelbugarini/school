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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items[1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarMatricula() &&
                validarRequeridos())
            {
                dataGridView1.Rows.Add(textBox1.Text,
                       textBox2.Text,
                       textBox3.Text,
                       textBox4.Text,
                       textBox5.Text,
                       textBox6.Text,
                       comboBox1.Text
                       );
            }
        }

        private bool validarMatricula()
        {
            try
            {
                int.Parse(textBox1.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Matricula no valida");
                return false;
            }
        }

        private bool validarRequeridos()
        {
            if (textBox1.Text != "" &&
                textBox2.Text != "" &&
                textBox3.Text != "" &&
                textBox4.Text != "")
                return true;
            else
                MessageBox.Show("Falta algun campo requerido"); return false;
        }

        private bool validarMatriculaNoRepetida()
        {
            return false;
        }
    }
}
