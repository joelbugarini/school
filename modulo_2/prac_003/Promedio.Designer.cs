namespace prac_003
{
    partial class Promedio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_captura = new System.Windows.Forms.Label();
            this.btn_capturar = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_Mayor = new System.Windows.Forms.Label();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.lbl_Matriz = new System.Windows.Forms.Label();
            this.lbl_Menor = new System.Windows.Forms.Label();
            this.lbl_Suma = new System.Windows.Forms.Label();
            this.lbl_Promedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(12, 9);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(240, 13);
            this.lbl_descripcion.TabIndex = 0;
            this.lbl_descripcion.Text = "Programa que calcula el promedio de 15 numeros";
            // 
            // lbl_captura
            // 
            this.lbl_captura.AutoSize = true;
            this.lbl_captura.Location = new System.Drawing.Point(41, 44);
            this.lbl_captura.Name = "lbl_captura";
            this.lbl_captura.Size = new System.Drawing.Size(103, 13);
            this.lbl_captura.TabIndex = 1;
            this.lbl_captura.Text = "Ingrese el numero 1:";
            // 
            // btn_capturar
            // 
            this.btn_capturar.Location = new System.Drawing.Point(44, 86);
            this.btn_capturar.Name = "btn_capturar";
            this.btn_capturar.Size = new System.Drawing.Size(75, 23);
            this.btn_capturar.TabIndex = 2;
            this.btn_capturar.Text = "Capturar";
            this.btn_capturar.UseVisualStyleBackColor = true;
            this.btn_capturar.Click += new System.EventHandler(this.btn_capturar_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(44, 60);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(165, 20);
            this.txt_numero.TabIndex = 3;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // lbl_Mayor
            // 
            this.lbl_Mayor.AutoSize = true;
            this.lbl_Mayor.Location = new System.Drawing.Point(215, 63);
            this.lbl_Mayor.Name = "lbl_Mayor";
            this.lbl_Mayor.Size = new System.Drawing.Size(39, 13);
            this.lbl_Mayor.TabIndex = 4;
            this.lbl_Mayor.Text = "Mayor:";
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.Location = new System.Drawing.Point(134, 86);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_Reiniciar.TabIndex = 6;
            this.btn_Reiniciar.Text = "Reiniciar";
            this.btn_Reiniciar.UseVisualStyleBackColor = true;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // lbl_Matriz
            // 
            this.lbl_Matriz.AutoSize = true;
            this.lbl_Matriz.Location = new System.Drawing.Point(41, 134);
            this.lbl_Matriz.Name = "lbl_Matriz";
            this.lbl_Matriz.Size = new System.Drawing.Size(0, 13);
            this.lbl_Matriz.TabIndex = 0;
            // 
            // lbl_Menor
            // 
            this.lbl_Menor.AutoSize = true;
            this.lbl_Menor.Location = new System.Drawing.Point(215, 83);
            this.lbl_Menor.Name = "lbl_Menor";
            this.lbl_Menor.Size = new System.Drawing.Size(40, 13);
            this.lbl_Menor.TabIndex = 7;
            this.lbl_Menor.Text = "Menor:";
            // 
            // lbl_Suma
            // 
            this.lbl_Suma.AutoSize = true;
            this.lbl_Suma.Location = new System.Drawing.Point(215, 101);
            this.lbl_Suma.Name = "lbl_Suma";
            this.lbl_Suma.Size = new System.Drawing.Size(37, 13);
            this.lbl_Suma.TabIndex = 8;
            this.lbl_Suma.Text = "Suma:";
            // 
            // lbl_Promedio
            // 
            this.lbl_Promedio.AutoSize = true;
            this.lbl_Promedio.Location = new System.Drawing.Point(215, 120);
            this.lbl_Promedio.Name = "lbl_Promedio";
            this.lbl_Promedio.Size = new System.Drawing.Size(54, 13);
            this.lbl_Promedio.TabIndex = 9;
            this.lbl_Promedio.Text = "Promedio:";
            // 
            // Promedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lbl_Promedio);
            this.Controls.Add(this.lbl_Suma);
            this.Controls.Add(this.lbl_Menor);
            this.Controls.Add(this.lbl_Matriz);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.lbl_Mayor);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_capturar);
            this.Controls.Add(this.lbl_captura);
            this.Controls.Add(this.lbl_descripcion);
            this.Name = "Promedio";
            this.Text = "Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_captura;
        private System.Windows.Forms.Button btn_capturar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_Mayor;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Label lbl_Matriz;
        private System.Windows.Forms.Label lbl_Menor;
        private System.Windows.Forms.Label lbl_Suma;
        private System.Windows.Forms.Label lbl_Promedio;
    }
}