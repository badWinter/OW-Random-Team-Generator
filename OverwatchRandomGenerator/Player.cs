using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchRandomGenerator
{
    class Player
    {
        public string Name { get; private set; }
        public Hero MyHero { get; private set; }

        public Player(string name)
        {
            SetName(name);
            MyHero = Hero.None;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetHero(Hero hero)
        {
            MyHero = hero;
        }
    }
}
