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
            pointDeVie = 100;
            minDegats = 20;
            maxDegats = 30;
            vitesse = 20;

        }
    }
}
