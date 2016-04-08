using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Paquet
    {
        private List<Carte> cartes_ = new List<Carte>();
        private static Random rng = new Random();  

        public Paquet()
        {

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
    }
}
