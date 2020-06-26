using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinImages.Classes
{
    public class JoinImagesClass
    {
        private List<Image> ImageList = new List<Image>();
        public enum JoinType { Horizontal, Vertical }

        /// <summary>
        /// Esta função é responsável por adicionar imagens a lista interna
        /// </summary>
        /// <param name="imgs">Imagens a serem adicionadas</param>
        public void AddImages(params Image[] imgs)
        {
            foreach (Image img in imgs)
            {
                ImageList.Add(img);
            }
        }

        /// <summary>
        /// Função responsável por retornar o tamanho da lista de imagens
        /// </summary>
        /// <returns></returns>
        public int CountImages()
        {
            return ImageList.Count;
        }

        /// <summary>
        /// Esta função é responsável por limpar a lista de imagens
        /// </summary>
        public void Clear()
        {
            ImageList.Clear();
        }

        /// <summary>
        /// Esta função é responsável por criar um grid de imagens em apenas uma direção (horizontal ou vertical)
        /// </summary>
        /// <param name="type">Tipo de criação de grid</param>
        public Image JoinImagesFlat(JoinType type)
        {
            Bitmap imgFinal = null;
            if (ImageList.Count > 0)
            {
                if (type == JoinType.Horizontal)
                {
                    imgFinal = new Bitmap(ImageList.Sum(item => { return item.Width; }), ImageList.Max(item => { return item.Height; }));
                    Graphics g = Graphics.FromImage(imgFinal);
                    int width = 0;
                    foreach (Image item in ImageList)
                    {
                        g.DrawImage(item, width, 0);
                        width += item.Width;
                    }
                }
                else
                {
                    imgFinal = new Bitmap(ImageList.Max(item => { return item.Width; }), ImageList.Sum(item => { return item.Height; }));
                    Graphics g = Graphics.FromImage(imgFinal);
                    int height = 0;
                    foreach (Image item in ImageList)
                    {
                        g.DrawImage(item, 0, height);
                        height += item.Height;
                    }
                }
            }
            return imgFinal;
        }

        /// <summary>
        /// Esta função é responsável por criar um grid de imagens de mesmo tamanho em apenas uma direção (horizontal ou vertical)
        /// </summary>
        /// <param name="type">Tipo de criação de grid</param>
        public Image JoinImagesFlat(JoinType type, int imgWidth, int imgHeight)
        {
            Bitmap imgFinal = null;
            if (ImageList.Count > 0)
            {
                if (type == JoinType.Horizontal)
                {
                    imgFinal = new Bitmap(imgWidth*ImageList.Count, imgHeight);
                    Graphics g = Graphics.FromImage(imgFinal);
                    int width = 0;
                    foreach (Image item in ImageList)
                    {
                        g.DrawImage(new Bitmap(item, imgWidth, imgHeight), width, 0);
                        width += imgWidth;
                    }
                }
                else
                {
                    imgFinal = new Bitmap(imgWidth, imgHeight*ImageList.Count);
                    Graphics g = Graphics.FromImage(imgFinal);
                    int height = 0;
                    foreach (Image item in ImageList)
                    {
                        g.DrawImage(new Bitmap(item,imgWidth, imgHeight), 0, height);
                        height += imgHeight;
                    }
                }
            }
            return imgFinal;
        }

        /// <summary>
        /// Esta função é responsável por criar um grid de imagens
        /// </summary>
        /// <param name="horizontalImages">Quantidade de imagens na horizontal</param>
        /// <param name="verticalImages">Quantidade de imagens na vertical</param>
        /// <param name="imgWidth">Largura padrão dos itens do grid</param>
        /// <param name="imgHeight">Altura padrão dos itens do grid</param>
        public Image JoinImagesDynamicGrid(int horizontalImages, int verticalImages, int imgWidth, int imgHeight)
        {
            Bitmap imgFinal = new Bitmap(imgWidth * horizontalImages, imgHeight * verticalImages);
            Graphics g = Graphics.FromImage(imgFinal);
            int count = 0;
            for (int y = 0; y < verticalImages; y++)
            {
                for (int x = 0; x < horizontalImages; x++)
                {
                    if (count < ImageList.Count)
                        g.DrawImage(new Bitmap(ImageList[count], imgWidth, imgHeight), imgWidth * x, imgHeight * y);
                    count++;
                }
            }
            return imgFinal;
        }
    }
}
