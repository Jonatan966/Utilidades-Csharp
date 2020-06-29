using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageResizer.Classes;

namespace ImageResizer.TesteVisual
{
    public partial class FrmPrincipal : Form
    {
        List<Image> images = new List<Image>();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSelecionarImagens_Click(object sender, EventArgs e)
        {
            if (objSelecionaImagens.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in objSelecionaImagens.FileNames)
                {
                    images.Add(new Bitmap(item));
                }
                lblContador.Text = $"{images.Count} imagens";
            }
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            if (objSalvaImagens.ShowDialog() == DialogResult.OK)
            {
                if (txbPorcentagem.Value == 0)
                {
                    if (images.Count == 1)
                        ImageResizerClass.ResizeAndSaveImageExact(images[0], (int)txbLargura.Value, (int)txbAltura.Value, objSalvaImagens.SelectedPath, ImageFormat.Jpeg);
                    else
                        ImageResizerClass.ResizeAndSaveImagesExact(images, (int)txbLargura.Value, (int)txbAltura.Value, objSalvaImagens.SelectedPath, ImageFormat.Jpeg);
                }
                else
                {
                    if (images.Count == 1)
                        ImageResizerClass.ResizeAndSaveImageInPercent(images[0], (int)txbPorcentagem.Value, objSalvaImagens.SelectedPath, ImageFormat.Jpeg);
                    else
                        ImageResizerClass.ResizeAndSaveImagesInPercent(images, (int)txbPorcentagem.Value, objSalvaImagens.SelectedPath, ImageFormat.Jpeg);
                }
            }
        }
    }
}
