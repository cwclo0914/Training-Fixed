using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Fish
    {
        //Fields
        private System.Windows.Forms.PictureBox picture;

        //Constructors
        public Fish(int positionX, int positionY, double speed, int destinationX, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            DestinationX = destinationX;
            this.picture = picture;
        }

        //Porperties
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public double Speed { get; set; }
        public int DestinationX { get; set; }
        //Methods
        public void Swim(out int x, out int y)
        {
            PositionX += (int)Speed;

            if (PositionX >= DestinationX)
            {
                PositionX = 0 - picture.Size.Width;
            }

            x = PositionX;
            y = PositionY;
        }

        public int Eat(int point, System.Windows.Forms.PictureBox bait)
        {
            int distance = (picture.Location.X + picture.Size.Width) - (bait.Location.X + bait.Size.Width);
            if (distance >= 0 && distance <= 30)
            {
                PositionX = -picture.Size.Width;
                PictureMove(PositionX, PositionY);
            }
            else
            {
                point = 0;
            }
            return point;
        }

        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
