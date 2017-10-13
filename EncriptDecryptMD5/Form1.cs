using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUtils;

namespace EncriptDecryptMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encriptar_Click(object sender, EventArgs e)
        {
            tb_encriptado.Text = MyUtils.EncryptString(tb_encriptar.Text);
        }

        private void btn_desencriptar_Click(object sender, EventArgs e)
        {
            tb_desencriptado.Text = MyUtils.DecryptString(tb_desencriptar.Text);
        }
    }
}
