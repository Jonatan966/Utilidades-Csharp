using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ConversorBase64.Classe
{
    public static class ConversorImageBase64
    {
        /// <summary>
        /// Esta função converte uma string em formato Base64 para uma imagem
        /// </summary>
        /// <param name="imgBase64"><see cref="string"/> em formato Base64</param>
        /// <returns>Retorna o resultado final da conversão</returns>
        public static Image Base64ParaImagem(string imgBase64)
        {
            //Este trecho é responsável por converter o texto para um byte[]
            byte[] bytes = Convert.FromBase64String(imgBase64);

            //Converte o byte[] gerado para Image
            using (var imgStream = new MemoryStream(bytes, 0, bytes.Length))
            {
                return Image.FromStream(imgStream, true);
            }
        }

        /// <summary>
        /// Esta função converte uma imagem para uma <see cref="string"/> no formato Base64
        /// </summary>
        /// <param name="img">Imagem a ser convertida</param>
        /// <returns>Retorna uma <see cref="string"/> em formato Base64</returns>
        public static string ImageParaBase64(Image img)
        {
            ImageFormat formato = img.RawFormat;
            using (MemoryStream imgStream = new MemoryStream())
            {
                //Este trecho é responsável por converter o Image para byte[]
                img.Save(imgStream, formato);
                byte[] imgBytes = imgStream.ToArray();

                //Este trecho é responsável por converter o byte[] gerado anteriormente para uma string
                return Convert.ToBase64String(imgBytes);
            }
        }
    }
}
