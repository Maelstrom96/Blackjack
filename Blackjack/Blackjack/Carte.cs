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
        public const int WIDTH = 300;
        public const int HEIGHT = 436;

        private honneur honneur_;
        private ushort point_;
        private Bitmap image_;
        private Face face_; 

        public static Bitmap Back = ResizeImage(Properties.Resources.back);
        public honneur Honneur { get { return honneur_; } }
        public ushort Point { get { return point_; } }
        public Bitmap Image { get { return image_; } }
        public Face FaceCourante { get { return face_; } }

        public Carte(honneur honneur, ushort point)
        {
            face_ = Face.Dos;
            honneur_ = honneur;
            point_ = point;
            image_ = GetImage();

            // RESIZE
            image_ = ResizeImage(image_);  
        }

        private Bitmap GetImage()
        {
            string filename = "_" + (int)Honneur + Point;
            return (Bitmap)Properties.Resources.ResourceManager.GetObject(filename);
        }

        private static Bitmap ResizeImage(Bitmap originale)
        {
            return new Bitmap(originale, new Size(WIDTH, HEIGHT));
        }
    }

    public enum honneur
    {
        Pique = 1,
        Carreau = 2,
        Coeur = 3,
        Trefle = 4
    }

    public enum Face
    {
        Face = 1,
        Dos = 2
    }
}
