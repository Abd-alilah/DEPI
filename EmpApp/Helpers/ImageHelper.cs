using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataApp.Helpers
{
    public static class ImageHelper
    {
        public static byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ConvertByteArrayToImage(Byte[] imagebytes)
        {
            if (imagebytes == null || imagebytes.Length == 0) return null;
            using(MemoryStream ms = new MemoryStream(imagebytes))
            {
                return Image.FromStream(ms);
            }

        }


    }
}
