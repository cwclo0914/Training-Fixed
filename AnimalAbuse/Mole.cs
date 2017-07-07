using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalAbuse
{
    class Mole : HappyAnimal
    {
        private Random randm = new Random();

        private int speedX;

        public Mole(int originX, int originY, int speed)
            : base(originX, originY, speed, Properties.Resources.mole)
        {
            speedX = -(Speed + randm.Next(0, 60));
        }


        public override void Appear()
        {
            base.Visible = true;
        }

        public override void Movement()
        {
            base.Moving = true;

            int x = base.Location.X;
            int y = base.Location.Y;

            //Moving
            x += speedX;

            //Turning upon collision
            if (x <= 0)
            {
                x = 0;
                speedX = -speedX;
            }
            else if (x + base.Size.Width >= Form1.formSizeW)
            {
                x = Form1.formSizeW - base.Size.Width;
                speedX = -speedX;
            }

            base.Location = new Point(x, y);
        }

        public override int Hit()
        {
            base.Visible = false;
            Moving = false;

            Score += 1;
            return Score;
        }
    }
}
