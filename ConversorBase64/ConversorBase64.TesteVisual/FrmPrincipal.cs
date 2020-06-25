using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ConversorBase64.Classe;

namespace ConversorBase64.TesteVisual
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSelecionarImagem_Click(object sender, EventArgs e)
        {
            if (objSelecionaImagem.ShowDialog() == DialogResult.OK)
            {
                pbxImagem.Image = new Bitmap(objSelecionaImagem.FileName);
                btnConvImgParaArquivo.Enabled = btnConvImgParaTexto.Enabled = true;
            }
        }

        private void BtnConverterTexto_Click(object sender, EventArgs e)
        {
            try
            {
                pbxImagem.Image = ConversorImageBase64.Base64ParaImagem(txbBase64.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Não foi possível converter este texto para uma imagem.\nMotivo: "+exc.Message,"Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            pbxImagem.Image = null;
            txbBase64.Clear();
            btnConvImgParaArquivo.Enabled = btnConvImgParaTexto.Enabled = false;
        }

        private void BtnConvImgParaArquivo_Click(object sender, EventArgs e)
        {
            if (objSalvaTexto.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter oEscrita = File.CreateText(objSalvaTexto.FileName))
                {
                    oEscrita.Write(ConversorImageBase64.ImageParaBase64(pbxImagem.Image));
                    oEscrita.Close();
                    MessageBox.Show("Arquivo salvo com sucesso!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void BtnConvImgParaTexto_Click(object sender, EventArgs e)
        {
            string result = ConversorImageBase64.ImageParaBase64(pbxImagem.Image);
            if (result.Length > txbBase64.Text.Length)
            {
                MessageBox.Show("Esta imagem resultou em um texto maior do que o esperado, portanto só poderá ser convertida para um arquivo de texto.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else txbBase64.Text = result;
        }

        private void TxbBase64_TextChanged(object sender, EventArgs e)
        {
            btnConverterTexto.Enabled = !string.IsNullOrWhiteSpace(txbBase64.Text);
        }
    }
}
