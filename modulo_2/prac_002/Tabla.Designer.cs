namespace prac_002
{
    partial class Tabla
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
            this.rtx_Resultado = new System.Windows.Forms.RichTextBox();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtx_Resultado
            // 
            this.rtx_Resultado.Location = new System.Drawing.Point(12, 75);
            this.rtx_Resultado.Name = "rtx_Resultado";
            this.rtx_Resultado.Size = new System.Drawing.Size(560, 274);
            this.rtx_Resultado.TabIndex = 0;
            this.rtx_Resultado.Text = "";
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(118, 46);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(75, 23);
            this.btn_Generar.TabIndex = 1;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(12, 46);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 2;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(13, 13);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(296, 13);
            this.lbl_Descripcion.TabIndex = 3;
            this.lbl_Descripcion.Text = "Programa que muestra la tabla de multiplicar del numero dado";
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.rtx_Resultado);
            this.Name = "Tabla";
            this.Text = "Tabla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtx_Resultado;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_Descripcion;
    }
}