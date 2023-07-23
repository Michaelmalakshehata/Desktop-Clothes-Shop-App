using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DAL.Extension_Methods
{
    public static class ImageConverter
    {
        public static byte[] converttobyte(BitmapImage image)
        {
            try
            {
                MemoryStream memstream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));
                encoder.Save(memstream);
                return memstream.ToArray();
            }
            catch
            {
                throw;
            }

        }

        public static BitmapImage ConvertToImage(byte[] img)
        {
            try
            {
                if (img == null || img.Length == 0) return new BitmapImage();
                var image = new BitmapImage();
                using (var meme = new MemoryStream(img))
                {
                    meme.Position = 0;
                    image.BeginInit();
                    image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.UriSource = null;
                    image.StreamSource = meme;
                    image.EndInit();

                }
                image.Freeze();
                return image;
            }
            catch
            {
                throw;
            }
        }
    }
}
