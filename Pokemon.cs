using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpPokemon
{
    public abstract class Pokemon : Entite
    {
        private int niveau;
        private int xp;
        

        protected Pokemon(string nom) : base(nom)
        {
            this.nom = nom;
            niveau = 1;
            xp = 0;
            
        }

        public void gangerXP(int xp)
        {
            this.xp += xp;
            while (this.xp >= experienceRequise())
            {
                niveau++;
                Console.WriteLine("Vous avez atteint le niveau " + niveau);
                pointDeVie += 5;
                minDegats += 3;
                maxDegats += 3;
                vitesse += 5;
                nbPotion++;
                
            }
        }

       

        public void Fuite()
        {
            minDegats = 0;
            maxDegats = 0;
            Console.WriteLine("Vous avez fuis comme un lache !!!");
        }
        public double experienceRequise()
        {
            return Math.Round(4 * (Math.Pow(niveau, 3)/5));
        }

        public  string Caracteristique()
        {
            return this.nom +"\n" +
                "Point de vie" + pointDeVie + "\n" +
                "Niveau : " + niveau + "\n" +
                "Experience" + xp + "\n" +
                "Degats" + minDegats + "" + maxDegats;
        }
    }
}
