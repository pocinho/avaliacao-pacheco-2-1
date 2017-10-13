namespace EncriptDecryptMD5
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
            this.btn_desencriptar = new System.Windows.Forms.Button();
            this.tb_desencriptado = new System.Windows.Forms.TextBox();
            this.btn_encriptar = new System.Windows.Forms.Button();
            this.tb_desencriptar = new System.Windows.Forms.TextBox();
            this.tb_encriptado = new System.Windows.Forms.TextBox();
            this.tb_encriptar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_desencriptar
            // 
            this.btn_desencriptar.Location = new System.Drawing.Point(250, 197);
            this.btn_desencriptar.Name = "btn_desencriptar";
            this.btn_desencriptar.Size = new System.Drawing.Size(75, 23);
            this.btn_desencriptar.TabIndex = 9;
            this.btn_desencriptar.Text = "Desencriptar";
            this.btn_desencriptar.UseVisualStyleBackColor = true;
            this.btn_desencriptar.Click += new System.EventHandler(this.btn_desencriptar_Click);
            // 
            // tb_desencriptado
            // 
            this.tb_desencriptado.Location = new System.Drawing.Point(12, 230);
            this.tb_desencriptado.Name = "tb_desencriptado";
            this.tb_desencriptado.Size = new System.Drawing.Size(206, 20);
            this.tb_desencriptado.TabIndex = 6;
            // 
            // btn_encriptar
            // 
            this.btn_encriptar.Location = new System.Drawing.Point(250, 43);
            this.btn_encriptar.Name = "btn_encriptar";
            this.btn_encriptar.Size = new System.Drawing.Size(75, 23);
            this.btn_encriptar.TabIndex = 8;
            this.btn_encriptar.Text = "Ecriptar";
            this.btn_encriptar.UseVisualStyleBackColor = true;
            this.btn_encriptar.Click += new System.EventHandler(this.btn_encriptar_Click);
            // 
            // tb_desencriptar
            // 
            this.tb_desencriptar.Location = new System.Drawing.Point(12, 169);
            this.tb_desencriptar.Name = "tb_desencriptar";
            this.tb_desencriptar.Size = new System.Drawing.Size(206, 20);
            this.tb_desencriptar.TabIndex = 4;
            // 
            // tb_encriptado
            // 
            this.tb_encriptado.Location = new System.Drawing.Point(12, 77);
            this.tb_encriptado.Name = "tb_encriptado";
            this.tb_encriptado.Size = new System.Drawing.Size(206, 20);
            this.tb_encriptado.TabIndex = 7;
            // 
            // tb_encriptar
            // 
            this.tb_encriptar.Location = new System.Drawing.Point(12, 16);
            this.tb_encriptar.Name = "tb_encriptar";
            this.tb_encriptar.Size = new System.Drawing.Size(206, 20);
            this.tb_encriptar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 278);
            this.Controls.Add(this.btn_desencriptar);
            this.Controls.Add(this.tb_desencriptado);
            this.Controls.Add(this.btn_encriptar);
            this.Controls.Add(this.tb_desencriptar);
            this.Controls.Add(this.tb_encriptado);
            this.Controls.Add(this.tb_encriptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_desencriptar;
        private System.Windows.Forms.TextBox tb_desencriptado;
        private System.Windows.Forms.Button btn_encriptar;
        private System.Windows.Forms.TextBox tb_desencriptar;
        private System.Windows.Forms.TextBox tb_encriptado;
        private System.Windows.Forms.TextBox tb_encriptar;
    }
}

