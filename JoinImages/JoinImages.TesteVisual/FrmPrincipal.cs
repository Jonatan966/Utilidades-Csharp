using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoinImages.Classes;

namespace JoinImages.TesteVisual
{
    public partial class FrmPrincipal : Form
    {
        readonly JoinImagesClass img = new JoinImagesClass();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSelectImages_Click(object sender, EventArgs e)
        {
            if (objSelectImages.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in objSelectImages.FileNames)
                {
                    img.AddImages(new Bitmap(item));
                }
                lblImagens.Text = $"{img.CountImages()} imagens";
            }
        }

        private void BtnCreateVerticalGrid_Click(object sender, EventArgs e)
        {
            pbxResultado.Image = img.JoinImagesFlat(JoinImagesClass.JoinType.Vertical);
        }

        private void BtnCreateHorizontalGrid_Click(object sender, EventArgs e)
        {
            pbxResultado.Image = img.JoinImagesFlat(JoinImagesClass.JoinType.Horizontal);
        }

        private void BtnCreateDynamicGrid_Click(object sender, EventArgs e)
        {
            pbxResultado.Image = img.JoinImagesDynamicGrid(3, 2, 50, 50);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            img.Clear();
            pbxResultado.Image = null;
        }
    }
}
