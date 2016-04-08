using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Jeu
    {
        private Joueur[] joueurs_;
        private Paquet paquetPrincipal_ = new Paquet(new Point(100,100));

        public Jeu(Joueur[] joueurs)
        {
            joueurs_ = joueurs;
            paquetPrincipal_.Reset(); // Initialisation du paquet de carte.
        }

        public void Draw(Graphics graphics)
        {
            paquetPrincipal_.Draw(graphics);
        }
    }
}
