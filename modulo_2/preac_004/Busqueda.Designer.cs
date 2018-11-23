namespace preac_004
{
    partial class Busqueda
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Busqueda = new System.Windows.Forms.Button();
            this.rtx_Resultado = new System.Windows.Forms.RichTextBox();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa un texto para buscar una persona";
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.Location = new System.Drawing.Point(270, 33);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Size = new System.Drawing.Size(75, 23);
            this.btn_Busqueda.TabIndex = 1;
            this.btn_Busqueda.Text = "Buscar";
            this.btn_Busqueda.UseVisualStyleBackColor = true;
            this.btn_Busqueda.Click += new System.EventHandler(this.btn_Busqueda_Click);
            // 
            // rtx_Resultado
            // 
            this.rtx_Resultado.Location = new System.Drawing.Point(8, 61);
            this.rtx_Resultado.Name = "rtx_Resultado";
            this.rtx_Resultado.Size = new System.Drawing.Size(337, 108);
            this.rtx_Resultado.TabIndex = 2;
            this.rtx_Resultado.Text = "";
            // 
            // txt_Texto
            // 
            this.txt_Texto.Location = new System.Drawing.Point(12, 35);
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(252, 20);
            this.txt_Texto.TabIndex = 3;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 181);
            this.Controls.Add(this.txt_Texto);
            this.Controls.Add(this.rtx_Resultado);
            this.Controls.Add(this.btn_Busqueda);
            this.Controls.Add(this.label1);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Busqueda;
        private System.Windows.Forms.RichTextBox rtx_Resultado;
        private System.Windows.Forms.TextBox txt_Texto;
    }
}