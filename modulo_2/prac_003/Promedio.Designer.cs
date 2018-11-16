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
            this.lbl_resultado = new System.Windows.Forms.Label();
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
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 3;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(56, 143);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(58, 13);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "Resultado:";
            // 
            // Promedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lbl_resultado);
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
        private System.Windows.Forms.Label lbl_resultado;
    }
}