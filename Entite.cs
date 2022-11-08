using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpPokemon
{
    public abstract class Entite
    {
        protected string nom;
        protected int pointDeVie;
        protected int minDegats;
        protected int maxDegats;
        protected int vitesse;
        protected Random random = new Random(); 
        protected bool GameOver = false;
        protected int nbPotion;

        public Entite(string nom)
        {
            this.nom = nom;
        }

        public void Attaque (Entite entite)
        {
            int degats = random.Next(minDegats, maxDegats);
            if (this.vitesse > entite.vitesse)
            {
                degats *= 2;
            }else if (this.vitesse < entite.vitesse)
            {
                degats *=    2;
            }
            entite.PerdrePv(degats);
            Console.WriteLine(this.nom + " marbre " + entite.nom);
            Console.WriteLine(entite.nom + " a perdu " + degats + " point de vie." );
            Console.WriteLine("il reste " + entite.pointDeVie + " point de vie à " + entite.nom + " et " + this.pointDeVie + " point de vie à " + this.nom);
            if (entite.GameOver)
            {
                Console.WriteLine(entite.nom + " est mort ");
            }

        }

        public void Soin()
        {

            if (this.pointDeVie == 100)
            {
                Console.WriteLine("Vous avez déja la vie au max");
            }
            else if (nbPotion == 0)
            {
                Console.WriteLine("Plus de potion !");
            }
            else if (pointDeVie <= 25 && nbPotion >= 1)
            {
                pointDeVie = random.Next(10, 15);
                Console.WriteLine("Vous avez récuperé " + pointDeVie + "de PV");
            }

        }

        protected void PerdrePv(int pointDeVie)
        {
            this.pointDeVie -= pointDeVie;
            if (this.pointDeVie <= 0)
            {
                this.pointDeVie = 0;
                GameOver = true;
            }
        }

        public bool Dead()
        {
            return this.GameOver;
        }
        List<Entite> list = new List<Entite>();
        public void Capture(Entite entite)
        {
            if (entite.pointDeVie <=50)
	        {
                Console.WriteLine("Voulez vous capturer " + entite.nom);
                string reponse = Console.ReadLine();
                if(reponse == "O")
                {
                list.Add(entite);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vous avez capturer " + entite.nom);
                }else if(reponse == "N")
                {
                    Console.WriteLine("OK BON COMBAT ");
                }
            foreach (var item in list)
	        {
                Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine("Liste des pokemon capturé " + item.nom);
	        }
                
        	}

       }
    }
}
