namespace prac_003
{
    partial class Convertir
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
            this.txt_Radio = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Radio
            // 
            this.txt_Radio.Location = new System.Drawing.Point(94, 81);
            this.txt_Radio.Name = "txt_Radio";
            this.txt_Radio.Size = new System.Drawing.Size(100, 20);
            this.txt_Radio.TabIndex = 9;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(94, 116);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese el radio del circulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Programa que convierte un numero en metros a varias unidades";
            // 
            // Convertir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txt_Radio);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Convertir";
            this.Text = "Convertir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Radio;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}