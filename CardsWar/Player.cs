using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsWar
{
    class Player
    {
        //Constructors
        public Player()
        {
            CurrentOpenCardIndex = -1;
            PreviousOpenCardIndex = -1;
            Score = 0;
        }

        //Properties
        public int CurrentOpenCardIndex { get; set; }
        public int PreviousOpenCardIndex { get; set; }
        public int Score { get; set; }

        //Method
        public void ToPrevious()
        {
            PreviousOpenCardIndex = CurrentOpenCardIndex;
        }

        public void Reset()
        {
            CurrentOpenCardIndex = -1;
            Score = 0;
        }
    }
}
