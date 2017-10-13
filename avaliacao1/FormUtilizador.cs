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
using System.Xml;
using System.Xml.Linq;

namespace avaliacao1
{
    public partial class FormUtilizador : Form
    {
        XmlDocument doc;

        public FormUtilizador()
        {
            InitializeComponent();
        }

        private void FormUtilizador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ficheiro_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Ficheiro XML (*.xml)|*.xml";
            openFileDialog1.Title = "Escolhe o Ficheiro XML";
            openFileDialog1.ShowDialog();
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            if (tb_filename.Text != "")
            {
                doc = new XmlDocument();
                doc.Load(tb_filename.Text);

                RefrescarListaCDs();
            }
        }

        private void RefrescarListaCDs()
        {
            lst_cds.Items.Clear();

            XmlNodeList majorKeyList = doc.SelectNodes("/album/cd");

            foreach (XmlNode majorKeyNode in majorKeyList)
            {
                XmlElement majorElement = majorKeyNode as XmlElement;

                lst_cds.Items.Add(majorElement.Attributes.GetNamedItem("nome").Value);
                if (!cb_tipo_musica.Items.Contains(majorElement.Attributes.GetNamedItem("genero").Value))
                    cb_tipo_musica.Items.Add(majorElement.Attributes.GetNamedItem("genero").Value);
            }
        }

        private void lst_cds_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlNodeList majorKeyList = doc.SelectNodes("/album/cd");
            XmlNode majorKeyNode = majorKeyList.Item(lst_cds.SelectedIndex);
            XmlElement majorElement = majorKeyNode as XmlElement;

            tb_nome.Text = majorElement.Attributes.GetNamedItem("nome").Value;
            tb_titulo.Text = majorElement.Attributes.GetNamedItem("titulo").Value;
            tb_genero.Text = majorElement.Attributes.GetNamedItem("genero").Value;
            tb_autor.Text = majorElement.Attributes.GetNamedItem("autor").Value;
            tb_ano.Text = majorElement.Attributes.GetNamedItem("ano").Value;
            tb_imagem.Text = majorElement.Attributes.GetNamedItem("imagem").Value;

            if (File.Exists(Application.StartupPath + @"\Resources\" + tb_imagem.Text))
            {
                pb_imagem.Image = new Bitmap(Application.StartupPath + @"\Resources\" + tb_imagem.Text);
            }
            else
            {
                pb_imagem.Image = null;
            }
        }

        private void cb_tipo_musica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_filename.Text != "")
            {
                XDocument xml_doc = XDocument.Load(tb_filename.Text);
                var cds = from cd in xml_doc.Descendants("cd")
                          where ((cb_tipo_musica.SelectedIndex >= 0) ? (cd.Attribute("genero").Value == cb_tipo_musica.SelectedItem.ToString()) : true)
                          select new
                          {
                              nome = cd.Attribute("nome").Value
                          };

                lst_cds.Items.Clear();

                foreach (var c in cds)
                {
                    lst_cds.Items.Add(c.nome);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tb_filename.Text = openFileDialog1.FileName;
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Existem " + lst_cds.Items.Count.ToString() + " cds !");
        }
    }
}
