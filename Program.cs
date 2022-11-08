using System.ComponentModel.Design;
using System.Security.Cryptography;
using tpPokemon;

internal class Program
{
    static void Main(string[] args)
    {
        Menu();

    }
    
    static void Play(Pokemon monPokemon)
    {
       
        PokemonSauvage pokemon_Sauvage = new PokemonSauvage("Jolan");
        bool wins = true;
        bool NextGame = false;
            Console.WriteLine("1 Combat");
            Console.WriteLine("2 Soin");
            Console.WriteLine("3 Fuir");
            Console.WriteLine("4 Statistiques");
            switch (Console.ReadLine())
            {
                case "1":
                    // JE ME FAIS ATTAQUER
                    while (!pokemon_Sauvage.Dead())
                    {
                        pokemon_Sauvage.Attaque(monPokemon);
                        Console.WriteLine();
                        Console.ReadKey(true);
                        if (monPokemon.Dead())
                        {
                            wins = false;
                            break;
                        }
                        // MON POKEMON ATTAQUE
                        monPokemon.Attaque(pokemon_Sauvage);
                        Console.WriteLine();
                        Console.ReadKey(true);
                        monPokemon.Capture(pokemon_Sauvage);

                       
                    }
                    break;
                case "2":
                    monPokemon.Soin();
                    Console.WriteLine();
                    Console.ReadKey(true);
                    break ;
                case "3":
                    monPokemon.Fuite();
                    Console.WriteLine();
                    Console.ReadKey(true);
                    break;
                case "4":
                   Console.WriteLine( monPokemon.Caracteristique());
                    Console.WriteLine();
                    Console.ReadKey(true);
                break; 
            }
        if (wins)
        {
            monPokemon.gangerXP(4);
            Console.WriteLine(monPokemon.Caracteristique());
        }
    }
    static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("| | _____ _ __ ___ ___ _ __  \r\n | '_ \\ / _ \\| |/ / _ \\ '_ ` _ \\ / _ \\| '_ \\\r\n | |_) | (_) | < __/ | | | | | (_) | | | |\r\n | .__/ \\___/|_|\\_\\___|_| |_| |_|\\___/|_| |_|\r\n |_|");
        Console.WriteLine("Choisis ton Pokemon ");
        Console.WriteLine();
        Console.WriteLine("1 - Pikachu");
        Console.WriteLine("2 - Salemeche");
        Console.WriteLine("3 - Bulbizar");
        Console.WriteLine("4 - Quitter");

        switch (Console.ReadLine())
        {
            case "1":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vous avez choisis Pikachu");
                Console.WriteLine("    ,___ .-;'\r\n`\"-.`\\_...._/`.`\r\n,\\ /\r\n .-' ', / () ()\\\r\n`'._ \\ /() . (|\r\n> .' ;, -'- /\r\n/<|;, __.;\r\n   '-.'-.| , \\ , \\\r\n      `>.|;, \\_) \\_)\r\n       `- ; , /\r\n          \\ / <\r\n           '. <`'-,_)\r\n        jgs'._)");
                Play(new Pikachu("SOUIHI"));
                break;
            case "2":
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Vous avez choisis Salameche");
                Console.WriteLine("    ,___ .-;'\r\n       `\"-.`\\_...._/`.`\r\n    , \\ /\r\n .-' ', / () ()\\\r\n`'._ \\ /() . (|\r\n    > .' ;, -'- /\r\n   / < |;, __.;\r\n   '-.'-.| , \\ , \\\r\n      `>.|;, \\_) \\_)\r\n       `- ; , /\r\n          \\ / <\r\n           '. <`'-,_)\r\n        jgs'._)");
                Play(new Salameche("SOUIHI"));
                break;
            case "3":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vous avez choisis Bulbizar");
                Console.WriteLine("    ,___ .-;'\r\n`\"-.`\\_...._/`.`\r\n    , \\ /\r\n .-' ', / () ()\\\r\n`'._ \\ /() . (|\r\n    > .' ;, -'- /\r\n   / < |;, __.;\r\n   '-.'-.| , \\ , \\\r\n      `>.|;, \\_) \\_)\r\n       `- ; , /\r\n          \\ / <\r\n           '. <`'-,_)\r\n        jgs'._)");
                Play(new Bulbizar("SOUIHI"));
                break;
            case "4":
                break;
        }
    }
}