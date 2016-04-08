using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Paquet
    {
        private List<Carte> cartes_ = new List<Carte>();
        private static Random rng = new Random();
        private uint maxwidth_;
        private Point position_; // center-top
        private static uint viewwidth_ = Carte.WIDTH / 6;
        private static uint maxviewwidth = Carte.WIDTH / 4;
        private bool modification_ = true;

        public Paquet(Point position, uint maxwidth = 500)
        {
            position_ = position;
            maxwidth_ = maxwidth;
        }

        public void Brasser()
        {
            int index = cartes_.Count;
            while (index > 1)
            {
                index--;
                int k = rng.Next(index + 1);
                Carte tmp = cartes_[k];
                cartes_[k] = cartes_[index];
                cartes_[index] = tmp;
            }  
        }

        public void Clear()
        {
            cartes_.Clear();
        }

        public void Reset()
        {
            Clear();
            Populer();
            Brasser();
        }

        public void Populer()
        {
            for (int i = 1; i <= 4; i++)
                for (ushort y = 1; y <= 13; y++)
                    cartes_.Add(new Carte((honneur)i, y));
        }

        private void SetPositionCartes()
        {
            if (cartes_.Count > 1)
            {
                uint tmpWidth = (uint)(cartes_.Count * maxviewwidth) + Carte.WIDTH;

                if (maxwidth_ < tmpWidth) tmpWidth = maxwidth_;
                double step = (double)(tmpWidth - Carte.WIDTH) / (double)cartes_.Count;
                if (cartes_[0].FaceCourante == Face.Face) step = viewwidth_;
                uint start = (ushort)(position_.X - (tmpWidth / 2));

                int index = 0;

                foreach(Carte carte in cartes_.Reverse<Carte>())
                {
                    carte.Position = new Point((int)start + (int)(step * index), position_.Y);
                    index++;
                }
            }
            else if (cartes_.Count == 1) cartes_[0].Position = new Point(position_.X - (Carte.WIDTH / 2), position_.Y);
            modification_ = false; 
        }

        public void Draw(Graphics graphics)
        {
            if (modification_) SetPositionCartes();
            foreach (Carte carte in cartes_) carte.Draw(graphics);
        }
    }
}
