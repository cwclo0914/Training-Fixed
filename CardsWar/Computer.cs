using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsWar
{
    class Computer : Player
    {
        //Fields
        private bool[] cards = new bool[13];
        private Random randf = new Random();
        //Constructors
        public Computer()
        {
            CurrentOpenCardIndex = -1;
            PreviousOpenCardIndex = -1;
            Score = 0;
        }

        //Methods
        public int Draw()
        {
            int n = -1;

            while (n < 0)
            {
                n = randf.Next(0, 13);
                if (cards[n] == true)
                    n = -1;
            }
            cards[n] = true;
            CurrentOpenCardIndex = n;
            return n;
        }

        public new void Reset()
        {
            CurrentOpenCardIndex = -1;
            Score = 0;
            for (int i = 0; i < 13; i++)
            {
                cards[i] = false;
            }
        }      
    }
}
