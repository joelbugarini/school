namespace controles
{
    partial class Form3
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
            this.lbl_Numero1 = new System.Windows.Forms.Label();
            this.lbl_Numero2 = new System.Windows.Forms.Label();
            this.txt_Numero1 = new System.Windows.Forms.TextBox();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.btn_Comparar = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Numero1
            // 
            this.lbl_Numero1.AutoSize = true;
            this.lbl_Numero1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero1.Location = new System.Drawing.Point(31, 45);
            this.lbl_Numero1.Name = "lbl_Numero1";
            this.lbl_Numero1.Size = new System.Drawing.Size(55, 15);
            this.lbl_Numero1.TabIndex = 0;
            this.lbl_Numero1.Text = "Numero 1";
            // 
            // lbl_Numero2
            // 
            this.lbl_Numero2.AutoSize = true;
            this.lbl_Numero2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero2.Location = new System.Drawing.Point(31, 86);
            this.lbl_Numero2.Name = "lbl_Numero2";
            this.lbl_Numero2.Size = new System.Drawing.Size(57, 15);
            this.lbl_Numero2.TabIndex = 1;
            this.lbl_Numero2.Text = "Numero 2";
            // 
            // txt_Numero1
            // 
            this.txt_Numero1.Location = new System.Drawing.Point(87, 42);
            this.txt_Numero1.Name = "txt_Numero1";
            this.txt_Numero1.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero1.TabIndex = 2;
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.Location = new System.Drawing.Point(87, 83);
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero2.TabIndex = 3;
            // 
            // btn_Comparar
            // 
            this.btn_Comparar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comparar.Location = new System.Drawing.Point(220, 61);
            this.btn_Comparar.Name = "btn_Comparar";
            this.btn_Comparar.Size = new System.Drawing.Size(75, 23);
            this.btn_Comparar.TabIndex = 4;
            this.btn_Comparar.Text = "Comparar";
            this.btn_Comparar.UseVisualStyleBackColor = true;
            this.btn_Comparar.Click += new System.EventHandler(this.btn_Comparar_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(333, 66);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(56, 15);
            this.lbl_Resultado.TabIndex = 5;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::controles.Properties.Resources.note;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Comparar);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.txt_Numero1);
            this.Controls.Add(this.lbl_Numero2);
            this.Controls.Add(this.lbl_Numero1);
            this.Name = "Form3";
            this.Text = "Comparar Numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Numero1;
        private System.Windows.Forms.Label lbl_Numero2;
        private System.Windows.Forms.TextBox txt_Numero1;
        private System.Windows.Forms.TextBox txt_Numero2;
        private System.Windows.Forms.Button btn_Comparar;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}