using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUtils;

namespace avaliacao1
{
    public partial class FormInicio : Form
    {
        private string db_path = Application.StartupPath + @"\Resources\db_users.txt";

        public FormInicio()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            List<Utilizador> users = new List<Utilizador>();
            bool pass = false;
            bool user = false;

            using (StreamReader sr = File.OpenText(db_path))
            {
                try
                {
                    string read = null;
                    while ((read = sr.ReadLine()) != null)
                    {
                        users.Add(new Utilizador(read.Split(' ').ElementAt(0), read.Split(' ').ElementAt(1)));
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Aconteceu um erro ao aceder ao ficheiro:\n" + ee.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            foreach (Utilizador u in users)
            {
                if (u.Nome == tb_username.Text)
                {
                    user = true;
                    string d = MyUtils.EncryptString(tb_password.Text);
                    if (u.Pass == d)
                    {
                        pass = true;
                        if (u.Nome == "user")
                        {
                            FormUtilizador f = new FormUtilizador();
                            f.Show();
                            this.Hide();
                        }
                        else if (u.Nome == "admin")
                        {
                            FormAdministrador f = new FormAdministrador();
                            f.Show();
                            this.Hide();
                        }
                        break;
                    }
                    else
                    {
                        pass = false;
                    }
                }
            }

            if (!user)
                MessageBox.Show("Utilizador inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!pass)
                MessageBox.Show("Password inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
