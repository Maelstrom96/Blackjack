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
        public const int WIDTH = 121;
        public const int HEIGHT = 173;

        private honneur honneur_;
        private ushort point_;
        private Bitmap image_;
        private Face face_;
        private Point position_;

        public static Bitmap Dos = ResizeImage(Properties.Resources.back2);
        public honneur Honneur { get { return honneur_; } }
        public ushort Point { get { return point_; } }
        public Bitmap Image { get { return image_; } }
        public Point Position { get { return position_; } set { position_ = value; } }
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

        private Bitmap CurrentDisplay()
        {
            if (FaceCourante == Face.Face) return Image;
            else return Dos;
        }

        private static Bitmap ResizeImage(Bitmap originale)
        {
            return new Bitmap(originale, new Size(WIDTH, HEIGHT));
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(CurrentDisplay(), Position);
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
