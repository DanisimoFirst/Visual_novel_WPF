using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    class GrapicsChanger
    {
        public GameWindow УстанавливаетНовуюКартинку
        {
            get => default;
            set
            {
            }
        }



        public static ImageBrush GrapicChanger()
        {
            
            var Background = new ImageBrush(new BitmapImage(new Uri(PathOfImageConstructor(), UriKind.Absolute)));
            return Background;
        }
        public static string PathOfImageConstructor()
        {
            string PathOFImage;
            PathOFImage = null;
            PathOFImage = @"C:\IDS\C#\IDSgame\WpfApp1\WpfApp1\resourses\Graphics\" + GameWindow.ID + ".jpg";
            return PathOFImage;
        }
   
    }
}
