using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpPokemon
{
    public class Salameche : Pokemon
    {
        public Salameche(string nom) : base(nom)
        {
            pointDeVie = 500;
            minDegats = 10;
            maxDegats = 20;
            vitesse = 20;

        }
    }
}
