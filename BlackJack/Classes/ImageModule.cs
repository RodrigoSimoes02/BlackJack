using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BlackJack.Classes
{
    class ImageModule
    {
        private static string GetImageDirectoryPNG(int CardID)
        {
            string Directory = "/Cards/" + CardID + ".png";
            return Directory;
        }

        private static Uri GetUri(int CardID)
        {
            Uri resourceUri = new Uri(ImageModule.GetImageDirectoryPNG(CardID), UriKind.Relative);
            return resourceUri;
        }

        public static BitmapImage GetImage(int CardID)
        {
            Uri uri = GetUri(CardID);
            return new BitmapImage(uri);
        }

        public static BitmapImage GetBackground()
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("/bin/Background.png", UriKind.Relative);
            image.EndInit();
            return image;
        }
    }
}
