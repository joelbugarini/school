﻿namespace preac_004
{
    partial class Letras
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_Invertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 29);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe una palabra de 11 letras";
            // 
            // label2
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(12, 103);
            this.lbl_resultado.Name = "label2";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 24);
            this.lbl_resultado.TabIndex = 2;
            // 
            // btn_Invertir
            // 
            this.btn_Invertir.Location = new System.Drawing.Point(197, 17);
            this.btn_Invertir.Name = "btn_Invertir";
            this.btn_Invertir.Size = new System.Drawing.Size(75, 23);
            this.btn_Invertir.TabIndex = 3;
            this.btn_Invertir.Text = "Invertir";
            this.btn_Invertir.UseVisualStyleBackColor = true;
            this.btn_Invertir.Click += new System.EventHandler(this.btn_InvertirClick);
            // 
            // Letras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.btn_Invertir);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Letras";
            this.Text = "Letras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_Invertir;
    }
}