namespace controles
{
    partial class Form2
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
            this.btn_Igual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.lbl_a_mas_b = new System.Windows.Forms.Label();
            this.lbl_a_menos_b = new System.Windows.Forms.Label();
            this.lbl_a_por_b = new System.Windows.Forms.Label();
            this.lbl_a_entre_b = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Igual
            // 
            this.btn_Igual.Location = new System.Drawing.Point(304, 158);
            this.btn_Igual.Name = "btn_Igual";
            this.btn_Igual.Size = new System.Drawing.Size(75, 23);
            this.btn_Igual.TabIndex = 0;
            this.btn_Igual.Text = "=";
            this.btn_Igual.UseVisualStyleBackColor = true;
            this.btn_Igual.Click += new System.EventHandler(this.btn_Igual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(169, 140);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(100, 20);
            this.txt_A.TabIndex = 3;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(169, 180);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(100, 20);
            this.txt_B.TabIndex = 4;
            // 
            // lbl_a_mas_b
            // 
            this.lbl_a_mas_b.AutoSize = true;
            this.lbl_a_mas_b.Location = new System.Drawing.Point(444, 130);
            this.lbl_a_mas_b.Name = "lbl_a_mas_b";
            this.lbl_a_mas_b.Size = new System.Drawing.Size(31, 13);
            this.lbl_a_mas_b.TabIndex = 5;
            this.lbl_a_mas_b.Text = "a + b";
            // 
            // lbl_a_menos_b
            // 
            this.lbl_a_menos_b.AutoSize = true;
            this.lbl_a_menos_b.Location = new System.Drawing.Point(444, 155);
            this.lbl_a_menos_b.Name = "lbl_a_menos_b";
            this.lbl_a_menos_b.Size = new System.Drawing.Size(28, 13);
            this.lbl_a_menos_b.TabIndex = 6;
            this.lbl_a_menos_b.Text = "a - b";
            // 
            // lbl_a_por_b
            // 
            this.lbl_a_por_b.AutoSize = true;
            this.lbl_a_por_b.Location = new System.Drawing.Point(444, 180);
            this.lbl_a_por_b.Name = "lbl_a_por_b";
            this.lbl_a_por_b.Size = new System.Drawing.Size(30, 13);
            this.lbl_a_por_b.TabIndex = 7;
            this.lbl_a_por_b.Text = "a x b";
            // 
            // lbl_a_entre_b
            // 
            this.lbl_a_entre_b.AutoSize = true;
            this.lbl_a_entre_b.Location = new System.Drawing.Point(444, 206);
            this.lbl_a_entre_b.Name = "lbl_a_entre_b";
            this.lbl_a_entre_b.Size = new System.Drawing.Size(30, 13);
            this.lbl_a_entre_b.TabIndex = 8;
            this.lbl_a_entre_b.Text = "a / b";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::controles.Properties.Resources.note;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lbl_a_entre_b);
            this.Controls.Add(this.lbl_a_por_b);
            this.Controls.Add(this.lbl_a_menos_b);
            this.Controls.Add(this.lbl_a_mas_b);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Igual);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Igual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.Label lbl_a_mas_b;
        private System.Windows.Forms.Label lbl_a_menos_b;
        private System.Windows.Forms.Label lbl_a_por_b;
        private System.Windows.Forms.Label lbl_a_entre_b;
    }
}