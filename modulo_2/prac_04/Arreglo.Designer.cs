namespace prac_004
{
    partial class Arreglo
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
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.btn_Capturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matriz[0]=";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero.Location = new System.Drawing.Point(140, 32);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(100, 26);
            this.txt_Numero.TabIndex = 1;
            // 
            // btn_Capturar
            // 
            this.btn_Capturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Capturar.Location = new System.Drawing.Point(246, 31);
            this.btn_Capturar.Name = "btn_Capturar";
            this.btn_Capturar.Size = new System.Drawing.Size(91, 28);
            this.btn_Capturar.TabIndex = 2;
            this.btn_Capturar.Text = "Capturar";
            this.btn_Capturar.UseVisualStyleBackColor = true;
            // 
            // Arreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btn_Capturar);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.label1);
            this.Name = "Arreglo";
            this.Text = "Arreglo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Button btn_Capturar;
    }
}

