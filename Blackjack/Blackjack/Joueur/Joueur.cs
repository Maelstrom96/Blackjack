﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    abstract class Joueur
    {
        //private Paquet paquet_ = new Paquet();
        private Boolean abandonner_ = false;
        private uint score_ = 0;
        public uint Score { get { return score_; } }

        public abstract void Jouer();

        public void NouvellePartie()
        {
            //paquet_.Clear();
        }

        public void Victoire()
        {
            score_++;
        }
    }
}
