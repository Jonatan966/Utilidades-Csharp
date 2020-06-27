using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IconMaker.Classes;

namespace IconMaker.TesteVisual
{
    public partial class Form1 : Form
    {
        List<Image> imagens = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }

        void AtualizaLegenda()
        {
            btnConverterImagens.Enabled = btnConverter2.Enabled = imagens.Count > 0;
            lblContadorImagens.Text = $"{imagens.Count} imagens selecionadas";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            imagens.Clear();
            AtualizaLegenda();
        }

        private void BtnConverterImagens_Click(object sender, EventArgs e)
        {
            if (objSalvaImagens.ShowDialog() == DialogResult.OK)
            {
                foreach (Image img in imagens)
                {
                    IconMakerClass.ConvertAndSaveImages(objSalvaImagens.SelectedPath, (int)txbTamanhoIcones.Value, img);
                }
                MessageBox.Show("Imagens convertidas com sucesso!", "Êxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar.PerformClick();
            }
        }

        private void BtnAdicionarImagem_Click(object sender, EventArgs e)
        {
            if (objSelecionarImagens.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in objSelecionarImagens.FileNames)
                {
                    imagens.Add(new Bitmap(item));
                }
            }
            AtualizaLegenda();
        }

        private void BtnConverter2_Click(object sender, EventArgs e)
        {
            if (objSalvaImagens.ShowDialog() == DialogResult.OK)
            {
                IconMakerClass.ConvertAndSaveImages(objSalvaImagens.SelectedPath, (int)txbTamanhoIcones.Value, imagens);
                MessageBox.Show("Imagens convertidas com sucesso!", "Êxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar.PerformClick();
            }
        }
    }
}
