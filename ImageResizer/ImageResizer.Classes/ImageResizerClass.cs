using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ImageResizer.Classes
{
    public static class ImageResizerClass
    {
        /// <summary>
        /// Este método é responsável por salvar uma imagem no diretório indicado
        /// </summary>
        /// <param name="img">Imagem a ser salva</param>
        /// <param name="destiny">Diretório onde a imagem será armazenada</param>
        /// <param name="imageFormat">Formato da imagem</param>
        private static void SaveImage(Image img, string destiny, ImageFormat imageFormat)
        {
            string fileName = $@"\{Guid.NewGuid()}-{DateTime.Now.TimeOfDay:hhmmssffffff}.{imageFormat}";
            img.Save($@"{destiny}\{fileName}", imageFormat);
        }

        #region Resize Image Exact
        /// <summary>
        /// Esta função é responsável por redimensionar uma imagem, de acordo com as dimensões passadas
        /// </summary>
        /// <param name="img">Imagem a ser redimensionada</param>
        /// <param name="destWidth">Largura final da imagem</param>
        /// <param name="destHeight">Altura final da imagem</param>
        /// <returns>Retorna a imagem redimensionada</returns>
        public static Image ResizeImageExact(Image img, int destWidth, int destHeight)
        {
            Bitmap bmImagem = new Bitmap(destWidth, destHeight, PixelFormat.Format64bppArgb);
            bmImagem.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            Graphics grImagem = Graphics.FromImage(bmImagem);
            grImagem.InterpolationMode = InterpolationMode.NearestNeighbor;

            grImagem.DrawImage(img,
                new Rectangle(0, 0, destWidth, destHeight),
                new Rectangle(0, 0, img.Width, img.Height),
                GraphicsUnit.Pixel);

            grImagem.Dispose();
            return bmImagem;
        }

        /// <summary>
        /// Este método é responsável por redimensionar uma imagem, de acordo com as dimensões passadas,
        /// e em seguida salvá-lo no diretório fornecido
        /// </summary>
        /// <param name="img">Imagem a ser redimensionada</param>
        /// <param name="destWidth">Largura final da imagem</param>
        /// <param name="destHeight">Altura final da imagem</param>
        /// <param name="destiny">Local onde a imagem será salva</param>
        /// <param name="imagesFormat">Formato da imagem</param>
        public static void ResizeAndSaveImageExact(Image img, int destWidth, int destHeight, string destiny, ImageFormat imagesFormat)
        {
            SaveImage(ResizeImageExact(img, destWidth, destHeight), destiny, imagesFormat);
        }

        /// <summary>
        /// Esta função é responsável por redimensionar uma lista de imagens, de acordo com as dimensões passadas
        /// </summary>
        /// <param name="img">Imagens a serem redimensionadas</param>
        /// <param name="destWidth">Largura final das imagens</param>
        /// <param name="destHeight">Altura final das imagens</param>
        /// <returns>Retorna uma lista de imagens redimensionadas</returns>
        public static List<Image> ResizeImagesExact(List<Image> imgs, int destWidth, int destHeight)
        {
            List<Image> final = new List<Image>();
            imgs.ForEach(img => { final.Add(ResizeImageExact(img, destWidth, destHeight)); });
            return final;
        }

        /// <summary>
        /// Este método é responsável por redimensionar uma lista de imagens, de acordo com as dimensões passadas,
        /// e em seguida salvá-las no diretório fornecido
        /// </summary>
        /// <param name="img">Imagens a serem redimensionadas</param>
        /// <param name="destWidth">Largura final das imagens</param>
        /// <param name="destHeight">Altura final das imagens</param>
        /// <param name="destiny">Local onde as imagens serão salvas</param>
        /// <param name="imagesFormat">Formato das imagens</param>
        public static void ResizeAndSaveImagesExact(List<Image> imgs, int destWidth, int destHeight, string destiny, ImageFormat imagesFormat)
        {
            ResizeImagesExact(imgs, destWidth, destHeight).ForEach(img => {
                SaveImage(img, destiny, imagesFormat);
            });
        }
        #endregion

        #region Resize Image in Percent
        /// <summary>
        /// Esta função é responsável por redimensionar uma imagem, de acordo com a porcentagem passada
        /// </summary>
        /// <param name="img">Imagem a ser redimensionada</param>
        /// <param name="percent">Porcentagem do redimensionamento</param>
        /// <returns>Retorna a imagem redimensionada</returns>
        public static Image ResizeImageInPercent(Image img, int percent)
        {
            float nPorcentagem = (float)percent / 100;
            int destWidth = (int)(img.Width * nPorcentagem), destHeight = (int)(img.Height * nPorcentagem);

            return ResizeImageExact(img,destWidth, destHeight);
        }

        /// <summary>
        /// Esta função é responsável por redimensionar uma imagem, de acordo com a porcentagem passada,
        /// e em seguida salvá-la no diretório fornecido
        /// </summary>
        /// <param name="img">Imagem a ser redimensionada</param>
        /// <param name="percent">Porcentagem do redimensionamento</param>
        /// <param name="destiny">Local onde a imagem será salva</param>
        /// <param name="imagesFormat">Formato da imagem</param>
        public static void ResizeAndSaveImageInPercent(Image img, int percent, string destiny, ImageFormat imagesFormat)
        {
            SaveImage(ResizeImageInPercent(img, percent), destiny, imagesFormat);
        }

        /// <summary>
        /// Esta função é responsável por redimensionar uma lista de imagens, de acordo com a porcentagem passada
        /// </summary>
        /// <param name="imgs">Imagens a serem redimensionadas</param>
        /// <param name="percent">Porcentagem do redimensionamento</param>
        /// <returns>Retorna uma lista de imagens redimensionadas</returns>
        public static List<Image> ResizeImagesInPercent(List<Image> imgs, int percent)
        {
            List<Image> final = new List<Image>();
            imgs.ForEach((img) => { final.Add(ResizeImageInPercent(img, percent)); });
            return final;
        }

        /// <summary>
        /// Esta função é responsável por redimensionar uma lista de imagens, de acordo com a porcentagem passada
        /// e em seguida salvá-las no diretório fornecido
        /// </summary>
        /// <param name="imgs">Imagens a serem redimensionadas</param>
        /// <param name="percent">Porcentagem do redimensionamento</param>
        /// <param name="destiny">Local onde as imagens serão salvas</param>
        /// <param name="imagesFormat">Formato das imagens</param>
        public static void ResizeAndSaveImagesInPercent(List<Image> imgs, int percent, string destiny, ImageFormat imagesFormat)
        {
            ResizeImagesInPercent(imgs, percent).ForEach(img => {
                SaveImage(img, destiny, imagesFormat);
            });
        }
        #endregion
    }
}
