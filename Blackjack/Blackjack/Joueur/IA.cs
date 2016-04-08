using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class IA : Joueur
    {
        override public void Jouer()
        {
            throw new NotImplementedException();
        }

    }

    enum NiveauRisque
    {
        Courageux = 1,
        Moyen = 2,
        Prudent = 3
    }
}
