using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpPokemon
{
    public class Bulbizar : Pokemon
    {
        public Bulbizar(string nom) : base (nom)
        {
            pointDeVie = 100;
            minDegats = 30;
            maxDegats = 55;
            vitesse = 10;
        }
    }
}
