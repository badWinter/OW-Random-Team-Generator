using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchRandomGenerator
{
    class HeroFactory
    {
        private Random random;
        private List<Player> players;
        public int GroupSize { get; private set; }

        public HeroFactory(List<Player> players, int groupSize, Random random)
        {
            this.players = players;
            this.random = random;
            GroupSize = groupSize;
        }

        public void UpdateSize(int groupSize)
        {
            GroupSize = groupSize;
        }

        public void GenerateTeam()
        {
            //create int array of chosen hero values to eliminate duplicates
            //loop for # of iterations equal to group size
            //generate random number between 0 and 23
            ////check if number is in array (use while loop)
            //////if not, add the number to array, update players[i] hero to int value casted to Hero
            List<int> duplicates = new List<int>();
            for (int i = 0; i < GroupSize; i++)
            {
                int randHero = random.Next(0, 24);

                while (duplicates.Contains(randHero))
                    randHero = random.Next(0, 24);

                players[i].SetHero((Hero)randHero);
                duplicates.Add(randHero);
            }
        }
    }

    enum Hero
    {
        // 24 total
        // offence
        Genji,
        McCree,
        Pharah,
        Reaper,
        Soldier76,
        Sombra,
        Tracer,

        // defence
        Bastion,
        Hanzo,
        Junkrat,
        Mei,
        Torbjorn,
        Widowmaker,

        // tank
        Dva,
        Orisa,
        Reinhardt,
        Roadhog,
        Winston,
        Zarya,

        // support
        Ana,
        Lucio,
        Mercy,
        Symmetra,
        Zenyatta,

        // null value
        None,
    }
}
