using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Iwashi : Fish
    {
        private bool asleep;
        //Constructors
        public Iwashi(int positionX, int positionY, double speed, int destinationX, System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, destinationX, picture)
        {
            asleep = false;
        }

        //Iwashi Methods
        public void Sleep()
        {
            asleep = true;
        }
        public void Wakeup()
        {
            asleep = false;
        }
        public new int Eat(int point, System.Windows.Forms.PictureBox bait)
        {
            if (!asleep)
            {
                if (point <= 3)
                {
                    point = base.Eat(point, bait);
                }
                else
                {
                    point = 0;
                }
            }
            else
            {
                point = 0;
            }
            return point;
        }
    }
}
