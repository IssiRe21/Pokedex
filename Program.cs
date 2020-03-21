using System;
using System.Collections.Generic;


namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pokemon version exprimidor de limon

            // List<Pokemon> pokedexList = new List<Pokemon>();
            // pokedexList.Add(new Pokemon("Eevee", 133));
            // pokedexList.Add(new Pokemon("Vaporeon", 134));
            // pokedexList.Add(new Pokemon("Jolteon", 135));
            // pokedexList.Add(new Pokemon("Flareon", 136));
            // pokedexList.Add(new Pokemon("Espeon", 196));
            // pokedexList.Add(new Pokemon("Umbreon", 197));
            // pokedexList.Add(new Pokemon("Leafeon", 470));
            // pokedexList.Add(new Pokemon("Glaceon", 471));
            // pokedexList.Add(new Pokemon("Sylveon", 700));
            // pokedexList.Add(new Pokemon("Cyndaquil", 155));

            Dictionary<string, int> descriptionPokedex = new Dictionary<string, int>();
            descriptionPokedex.Add("Eevee", 133);
            descriptionPokedex.Add("Vaporeon", 134);
            descriptionPokedex.Add("Jolteon", 135);
            descriptionPokedex.Add("Flareon", 136);
            descriptionPokedex.Add("Cyndaquil", 155);
            descriptionPokedex.Add("Espeon", 196);
            descriptionPokedex.Add("Umbreon", 197);
            descriptionPokedex.Add("Leafeon", 470);
            descriptionPokedex.Add("Glaceon", 471);
            descriptionPokedex.Add("Sylveon", 700);

            Dictionary<int, string> InversePokedex = new Dictionary<int, string>();
            InversePokedex.Add(133, "Eevee");
            InversePokedex.Add(134, "Vaporeon");
            InversePokedex.Add(135, "Jolteon");
            InversePokedex.Add(136, "Flareon");
            InversePokedex.Add(155, "Cyndaquil");
            InversePokedex.Add(196, "Espeon");
            InversePokedex.Add(197, "Umbreon");
            InversePokedex.Add(470, "Leafeon");
            InversePokedex.Add(471, "Glaceon");
            InversePokedex.Add(700, "Sylveon");



            //Find a id with the name
            int idPoke = descriptionPokedex.GetValueOrDefault("Eevee");
            Console.WriteLine($"Eevee id = {idPoke}");

            //Find a name with the id
            string namePoke = InversePokedex.GetValueOrDefault(133);
            Console.WriteLine($"Pokemon #133 = {namePoke}");


            // Show all the pokemon, name and id
            System.Console.WriteLine("All the pokemon:");
            foreach (var key in descriptionPokedex.Keys)
            {
                Console.Write(key + " ");
            }

            System.Console.WriteLine(" ");

            foreach (var value in descriptionPokedex.Values)
            {
                Console.Write(value + " ");
            }

            System.Console.WriteLine(" ");


            //Party
            System.Console.WriteLine("Party:");
            List<PokeCatch> Party = new List<PokeCatch>();
            Party.Add(new PokeCatch("Eevee", 133, Gender.Male));
            Party.Add(new PokeCatch("Eevee", 133, Gender.Male));
            Party.Add(new PokeCatch("Vaporeon", 134, Gender.Male));
            Party.Add(new PokeCatch("Espeon", 196, Gender.Female));
            Party.Add(new PokeCatch("Glaceon", 471, Gender.Female));
            Party.Add(new PokeCatch("Cyndaquil", 155, Gender.Male));

            foreach (var pokemon in Party)
            {
                System.Console.WriteLine(pokemon.Getname());
            }

            //Competitive Team
            System.Console.WriteLine("Competitive team:");
            List<PokeCatch> CompetitiveTeam = new List<PokeCatch>();
            CompetitiveTeam.Add(new PokeCatch("Eevee", 133, Gender.Male));
            CompetitiveTeam.Add(new PokeCatch("Eevee", 133, Gender.Male));
            CompetitiveTeam.Add(new PokeCatch("Espeon", 196, Gender.Female));

            if (CompetitiveTeam[0].Getid() == CompetitiveTeam[1].Getid())
            {
                System.Console.WriteLine("Error, change your team");
            }
            else
            {
                if (CompetitiveTeam[0].Getid() == CompetitiveTeam[2].Getid())
                {
                    System.Console.WriteLine("Error, change your team");
                }
                else
                {
                    if (CompetitiveTeam[1].Getid() == CompetitiveTeam[2].Getid())
                    {
                        System.Console.WriteLine("Error, change your team");
                    }
                    else
                    {
                        foreach (var pokemonCompetitive in CompetitiveTeam)
                        {
                            System.Console.WriteLine(pokemonCompetitive.Getname());
                        }
                    }
                }
            }

        }
    }
}
