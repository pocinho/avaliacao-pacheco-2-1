namespace avaliacao1
{
    partial class FormAdministrador
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
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_genero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_cds = new System.Windows.Forms.ListBox();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.btn_ficheiro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cb_tipo_musica = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_imagem = new System.Windows.Forms.TextBox();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(317, 186);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(258, 20);
            this.tb_ano.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ano:";
            // 
            // tb_autor
            // 
            this.tb_autor.Location = new System.Drawing.Point(317, 160);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(258, 20);
            this.tb_autor.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Autor:";
            // 
            // tb_genero
            // 
            this.tb_genero.Location = new System.Drawing.Point(317, 134);
            this.tb_genero.Name = "tb_genero";
            this.tb_genero.Size = new System.Drawing.Size(258, 20);
            this.tb_genero.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Genero:";
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(317, 108);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(258, 20);
            this.tb_titulo.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "CDs:";
            // 
            // lst_cds
            // 
            this.lst_cds.FormattingEnabled = true;
            this.lst_cds.HorizontalScrollbar = true;
            this.lst_cds.Location = new System.Drawing.Point(19, 101);
            this.lst_cds.Name = "lst_cds";
            this.lst_cds.Size = new System.Drawing.Size(158, 160);
            this.lst_cds.TabIndex = 14;
            this.lst_cds.SelectedIndexChanged += new System.EventHandler(this.lst_cds_SelectedIndexChanged);
            // 
            // btn_carregar
            // 
            this.btn_carregar.Location = new System.Drawing.Point(408, 41);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(167, 23);
            this.btn_carregar.TabIndex = 13;
            this.btn_carregar.Text = "Carregar XML";
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // tb_filename
            // 
            this.tb_filename.Location = new System.Drawing.Point(144, 15);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.ReadOnly = true;
            this.tb_filename.Size = new System.Drawing.Size(431, 20);
            this.tb_filename.TabIndex = 12;
            // 
            // btn_ficheiro
            // 
            this.btn_ficheiro.Location = new System.Drawing.Point(113, 13);
            this.btn_ficheiro.Name = "btn_ficheiro";
            this.btn_ficheiro.Size = new System.Drawing.Size(24, 23);
            this.btn_ficheiro.TabIndex = 11;
            this.btn_ficheiro.Text = "...";
            this.btn_ficheiro.UseVisualStyleBackColor = true;
            this.btn_ficheiro.Click += new System.EventHandler(this.btn_ficheiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Escolher Ficheiro:";
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(257, 380);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(75, 23);
            this.btn_total.TabIndex = 24;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(338, 380);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 24;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(419, 380);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 24;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(500, 380);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 24;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // cb_tipo_musica
            // 
            this.cb_tipo_musica.FormattingEnabled = true;
            this.cb_tipo_musica.Location = new System.Drawing.Point(317, 238);
            this.cb_tipo_musica.Name = "cb_tipo_musica";
            this.cb_tipo_musica.Size = new System.Drawing.Size(258, 21);
            this.cb_tipo_musica.TabIndex = 25;
            this.cb_tipo_musica.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_musica_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Selecionar Genero:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(317, 82);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(258, 20);
            this.tb_nome.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Imagem:";
            // 
            // tb_imagem
            // 
            this.tb_imagem.Location = new System.Drawing.Point(317, 212);
            this.tb_imagem.Name = "tb_imagem";
            this.tb_imagem.Size = new System.Drawing.Size(258, 20);
            this.tb_imagem.TabIndex = 20;
            // 
            // pb_imagem
            // 
            this.pb_imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_imagem.Location = new System.Drawing.Point(19, 267);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(158, 136);
            this.pb_imagem.TabIndex = 27;
            this.pb_imagem.TabStop = false;
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 415);
            this.Controls.Add(this.pb_imagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tipo_musica);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.tb_imagem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_autor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_genero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_cds);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.btn_ficheiro);
            this.Controls.Add(this.label1);
            this.Name = "FormAdministrador";
            this.Text = "Gestão de CDs - Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdministrador_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_genero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_cds;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.Button btn_ficheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cb_tipo_musica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_imagem;
        private System.Windows.Forms.PictureBox pb_imagem;
    }
}