using System.Drawing;
using System.Drawing.Imaging;

namespace Remedial_BIRU.Classes.Controllers
{
    class PictureController
    {
        public static Image ResizeImage(Image image, int newWidth, int newHeight)
        {
            Bitmap newImage = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        public static void SaveImageAsPNG(Image image, string filePath)
        {
            image.Save(filePath, ImageFormat.Png);
        }
    }
}
