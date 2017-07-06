using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Utubo : Fish
    {
        private double speed;
        private bool asleep;
        //Constructors
        public Utubo(int positionX, int positionY, double speed, int destinationX, System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, destinationX, picture)
        {
            this.speed = speed;
            asleep = false;
        }

        //Iwashi Methods
        public void Sleep()
        {
            asleep = true;
            base.Speed = 0;
        }
        public void Wakeup()
        {
            asleep = false;
            base.Speed = this.speed;
        }
        public new int Eat(int point, System.Windows.Forms.PictureBox bait)
        {
            if (!asleep)
            {
                if (point >= 7)
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
