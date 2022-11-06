using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpPokemon
{
    public class PokemonSauvage : Pokemon
    {
        public PokemonSauvage(string nom) : base(nom)
        {
            this.nom = nom;
            pointDeVie = 100;
            minDegats = 15;
            maxDegats = 35;
            vitesse = 12;
        }
    }
}
