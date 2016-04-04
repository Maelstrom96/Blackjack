using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Carte
    {
        private honneur honneur_;
        private ushort point_;
        private Bitmap image_;

        public static Bitmap Back = Properties.Resources.back;
        public honneur Honneur { get { return honneur_; } }
        public ushort Point { get { return point_; } }
        public Bitmap Image { get { return image_; } }

        public Carte(honneur honneur, ushort point)
        {
            honneur_ = honneur;
            point_ = point;
            image_ = GetImage();
        }

        private Bitmap GetImage()
        {
            string filename = "_" + (int)Honneur + Point;
            return (Bitmap)Properties.Resources.ResourceManager.GetObject(filename);
        }
    }

    public enum honneur
    {
        Pique = 1,
        Carreau = 2,
        Coeur = 3,
        Trefle = 4
    }
}
