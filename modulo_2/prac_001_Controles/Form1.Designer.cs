namespace controles
{
    partial class Form1
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
            this.btn_Capturar = new System.Windows.Forms.Button();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoPaterno = new System.Windows.Forms.Label();
            this.txt_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoMaterno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Capturar
            // 
            this.btn_Capturar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Capturar.Location = new System.Drawing.Point(477, 313);
            this.btn_Capturar.Name = "btn_Capturar";
            this.btn_Capturar.Size = new System.Drawing.Size(87, 27);
            this.btn_Capturar.TabIndex = 0;
            this.btn_Capturar.Text = "Capturar";
            this.btn_Capturar.UseVisualStyleBackColor = true;
            this.btn_Capturar.Click += new System.EventHandler(this.btn_Capturar_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(157, 121);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(50, 15);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(261, 117);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(189, 23);
            this.txt_Nombre.TabIndex = 2;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(157, 263);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 15);
            this.lbl_Resultado.TabIndex = 3;
            // 
            // txt_ApellidoPaterno
            // 
            this.txt_ApellidoPaterno.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ApellidoPaterno.Location = new System.Drawing.Point(261, 164);
            this.txt_ApellidoPaterno.Name = "txt_ApellidoPaterno";
            this.txt_ApellidoPaterno.Size = new System.Drawing.Size(189, 23);
            this.txt_ApellidoPaterno.TabIndex = 5;
            // 
            // lbl_ApellidoPaterno
            // 
            this.lbl_ApellidoPaterno.AutoSize = true;
            this.lbl_ApellidoPaterno.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoPaterno.Location = new System.Drawing.Point(157, 168);
            this.lbl_ApellidoPaterno.Name = "lbl_ApellidoPaterno";
            this.lbl_ApellidoPaterno.Size = new System.Drawing.Size(94, 15);
            this.lbl_ApellidoPaterno.TabIndex = 4;
            this.lbl_ApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // txt_ApellidoMaterno
            // 
            this.txt_ApellidoMaterno.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ApellidoMaterno.Location = new System.Drawing.Point(261, 213);
            this.txt_ApellidoMaterno.Name = "txt_ApellidoMaterno";
            this.txt_ApellidoMaterno.Size = new System.Drawing.Size(189, 23);
            this.txt_ApellidoMaterno.TabIndex = 7;
            // 
            // lbl_ApellidoMaterno
            // 
            this.lbl_ApellidoMaterno.AutoSize = true;
            this.lbl_ApellidoMaterno.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoMaterno.Location = new System.Drawing.Point(157, 217);
            this.lbl_ApellidoMaterno.Name = "lbl_ApellidoMaterno";
            this.lbl_ApellidoMaterno.Size = new System.Drawing.Size(98, 15);
            this.lbl_ApellidoMaterno.TabIndex = 6;
            this.lbl_ApellidoMaterno.Text = "Apellido Materno:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::controles.Properties.Resources.note;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txt_ApellidoMaterno);
            this.Controls.Add(this.lbl_ApellidoMaterno);
            this.Controls.Add(this.txt_ApellidoPaterno);
            this.Controls.Add(this.lbl_ApellidoPaterno);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_Capturar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Capturar;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_ApellidoPaterno;
        private System.Windows.Forms.Label lbl_ApellidoPaterno;
        private System.Windows.Forms.TextBox txt_ApellidoMaterno;
        private System.Windows.Forms.Label lbl_ApellidoMaterno;
    }
}

