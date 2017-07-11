using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalAbuse
{
    class Bird : HappyAnimal
    {
        private Random randm = new Random();

        private int speedX;
        private int speedY;

        public Bird(int originX, int originY, int speed)
            : base(originX, originY, speed, Properties.Resources.bird)
        {
            speedX = Speed + randm.Next(0, 35);
            speedY = Speed + randm.Next(0, 35);
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

            //Descending
            x += speedX;
            y += speedY;

            //Turning upon collision
            if (y <= 0)
            {
                y = 0;
                speedY = -speedY;
            }
            else if (y + base.Size.Height >= Form1.formSizeH)
            {
                y = Form1.formSizeH - base.Size.Height;
                speedY = -speedY;
            }
            else if (x <= 0)
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

            Score += 4;
            return Score;
        }
    }
}
