using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpPokemon
{
    public class Pikachu : Pokemon
    {
        public Pikachu(string nom) : base(nom)
        {
            pointDeVie = 100;
            minDegats = 100;
            maxDegats = 150;
            vitesse = 40;

        }

    }
}
