namespace prac_002
{
    partial class Farenheit
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
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_Centigrados = new System.Windows.Forms.TextBox();
            this.lbl_Centrigrados = new System.Windows.Forms.Label();
            this.lbl_Farenheit = new System.Windows.Forms.Label();
            this.txt_Farenheit = new System.Windows.Forms.TextBox();
            this.btn_Centigrados = new System.Windows.Forms.Button();
            this.btn_Farenheit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(47, 26);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(315, 13);
            this.lbl_Descripcion.TabIndex = 0;
            this.lbl_Descripcion.Text = "Programa para convertir de grados celsius a farenheit y viceversa";
            // 
            // txt_Centigrados
            // 
            this.txt_Centigrados.Location = new System.Drawing.Point(162, 101);
            this.txt_Centigrados.Name = "txt_Centigrados";
            this.txt_Centigrados.Size = new System.Drawing.Size(100, 20);
            this.txt_Centigrados.TabIndex = 1;
            // 
            // lbl_Centrigrados
            // 
            this.lbl_Centrigrados.AutoSize = true;
            this.lbl_Centrigrados.BackColor = System.Drawing.Color.White;
            this.lbl_Centrigrados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Centrigrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Centrigrados.Location = new System.Drawing.Point(368, 102);
            this.lbl_Centrigrados.Name = "lbl_Centrigrados";
            this.lbl_Centrigrados.Size = new System.Drawing.Size(2, 19);
            this.lbl_Centrigrados.TabIndex = 2;
            // 
            // lbl_Farenheit
            // 
            this.lbl_Farenheit.AutoSize = true;
            this.lbl_Farenheit.BackColor = System.Drawing.Color.White;
            this.lbl_Farenheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Farenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Farenheit.Location = new System.Drawing.Point(368, 169);
            this.lbl_Farenheit.Name = "lbl_Farenheit";
            this.lbl_Farenheit.Size = new System.Drawing.Size(2, 19);
            this.lbl_Farenheit.TabIndex = 3;
            // 
            // txt_Farenheit
            // 
            this.txt_Farenheit.Location = new System.Drawing.Point(162, 168);
            this.txt_Farenheit.Name = "txt_Farenheit";
            this.txt_Farenheit.Size = new System.Drawing.Size(100, 20);
            this.txt_Farenheit.TabIndex = 4;
            // 
            // btn_Centigrados
            // 
            this.btn_Centigrados.Location = new System.Drawing.Point(268, 99);
            this.btn_Centigrados.Name = "btn_Centigrados";
            this.btn_Centigrados.Size = new System.Drawing.Size(94, 23);
            this.btn_Centigrados.TabIndex = 5;
            this.btn_Centigrados.Text = "=";
            this.btn_Centigrados.UseVisualStyleBackColor = true;
            this.btn_Centigrados.Click += new System.EventHandler(this.btn_Centigrados_Click);
            // 
            // btn_Farenheit
            // 
            this.btn_Farenheit.Location = new System.Drawing.Point(268, 168);
            this.btn_Farenheit.Name = "btn_Farenheit";
            this.btn_Farenheit.Size = new System.Drawing.Size(94, 23);
            this.btn_Farenheit.TabIndex = 6;
            this.btn_Farenheit.Text = "=";
            this.btn_Farenheit.UseVisualStyleBackColor = true;
            this.btn_Farenheit.Click += new System.EventHandler(this.btn_Farenheit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Farenheit";
            // 
            // Farenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Farenheit);
            this.Controls.Add(this.btn_Centigrados);
            this.Controls.Add(this.txt_Farenheit);
            this.Controls.Add(this.lbl_Farenheit);
            this.Controls.Add(this.lbl_Centrigrados);
            this.Controls.Add(this.txt_Centigrados);
            this.Controls.Add(this.lbl_Descripcion);
            this.Name = "Farenheit";
            this.Text = "Farenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_Centigrados;
        private System.Windows.Forms.Label lbl_Centrigrados;
        private System.Windows.Forms.Label lbl_Farenheit;
        private System.Windows.Forms.TextBox txt_Farenheit;
        private System.Windows.Forms.Button btn_Centigrados;
        private System.Windows.Forms.Button btn_Farenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}