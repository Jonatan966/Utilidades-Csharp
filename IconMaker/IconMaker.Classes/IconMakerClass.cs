using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace IconMaker.Classes
{
    public static class IconMakerClass
    {
        /// <summary>
        /// Este método tem a função de converter uma imagem para um icone.
        /// </summary>
        /// <param name="iconSize">Tamanho do icone (valor máximo: 256)</param>
        /// <param name="img">Imagem a ser convertida</param>
        /// <returns>Retorna um <see cref="Icon"/> como resultado da conversão</returns>
        public static Icon ConvertImage(int iconSize, Image img)
        {
            byte[] pngIconHeader = new byte[] { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 24, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            using (Bitmap bmp = new Bitmap(img, new Size(iconSize, iconSize)))
            {
                byte[] png;
                using (MemoryStream fs = new MemoryStream())
                {
                    bmp.Save(fs, ImageFormat.Png);
                    fs.Position = 0;
                    png = fs.ToArray();
                }

                using (MemoryStream fs = new MemoryStream())
                {
                    if (iconSize >= 256) iconSize = 0;
                    pngIconHeader[6] = (byte)iconSize;
                    pngIconHeader[7] = (byte)iconSize;
                    pngIconHeader[14] = (byte)(png.Length & 255);
                    pngIconHeader[15] = (byte)(png.Length / 256);
                    pngIconHeader[18] = (byte)(pngIconHeader.Length);

                    fs.Write(pngIconHeader, 0, pngIconHeader.Length);
                    fs.Write(png, 0, png.Length);
                    fs.Position = 0;
                    return new Icon(fs);
                }
            }
        }

        /// <summary>
        /// Este método é responsável por converter um conjunto de imagens.
        /// </summary>
        /// <param name="iconSize">Tamanho dos icones (valor máximo: 256)</param>
        /// <param name="img">Imagens a serem convertidas</param>
        /// <returns>Retorna uma <see cref="List{Icon}"/> contendo os resultados da conversão</returns>
        public static List<Icon> ConvertImages(int iconSize, params Image[] img)
        {
            List<Icon> results = new List<Icon>();
            foreach (Image image in img)
            {
                results.Add(ConvertImage(iconSize, image));
            }
            return results;
        }

        /// <summary>
        /// Este método é responsável por converter um conjunto de imagens.
        /// </summary>
        /// <param name="iconSize">Tamanho dos icones (valor máximo: 256)</param>
        /// <param name="img">Imagens a serem convertidas</param>
        /// <returns>Retorna uma <see cref="List{Icon}"/> contendo os resultados da conversão</returns>
        public static List<Icon> ConvertImages(int iconSize, List<Image> img)
        {
            List<Icon> results = new List<Icon>();
            foreach (Image image in img)
            {
                results.Add(ConvertImage(iconSize, image));
            }
            return results;
        }

        /// <summary>
        /// Este método é responsável por converter um conjunto de imagens para icones,
        /// e em seguida salvá-las no diretório indicado.
        /// </summary>
        /// <param name="destiny">Diretório de salvamento dos icones</param>
        /// <param name="iconSize">Tamanho dos icones (valor máximo: 256)</param>
        /// <param name="img">Imagens a serem convertidas</param>
        public static void ConvertAndSaveImages(string destiny, int iconSize, params Image[] images)
        {
            foreach (Image item in images)
            {
                string fileName = $"{DateTime.Now:yyMMdd}{DateTime.Now.TimeOfDay:hhmmssffffff}.ico";
                using (FileStream fs = new FileStream(destiny+$@"\{fileName}", FileMode.Create))
                {
                    ConvertImage(iconSize, item).Save(fs);
                }
            }
        }

        /// <summary>
        /// Este método é responsável por converter um conjunto de imagens para icones,
        /// e em seguida salvá-las no diretório indicado.
        /// </summary>
        /// <param name="destiny">Diretório de salvamento dos icones</param>
        /// <param name="iconSize">Tamanho dos icones (valor máximo: 256)</param>
        /// <param name="img">Imagens a serem convertidas</param>
        public static void ConvertAndSaveImages(string destiny, int iconSize, List<Image> images)
        {
            ConvertImages(iconSize, images).ForEach((img) => {
                string fileName = $"{Guid.NewGuid()}-{DateTime.Now.TimeOfDay:hhmmssffffff}.ico";
                img.Save(new FileStream(destiny+ $@"\{fileName}.ico", FileMode.Create)); 
            });
        }
    }

}
