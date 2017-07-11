using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalAbuse
{
    class Cat : HappyAnimal
    {
        private Random randm = new Random();

        private int speedX;
        private int speedY;

        private bool horizontal;
        private bool btmrightflg;

        public Cat(int originX, int originY, int speed)
            : base(originX, originY, speed, Properties.Resources.cat_up)
        {
            speedX = Speed + randm.Next(0, 40);
            speedY = 0;
        }


        public override void Appear()
        {
            base.Visible = true;
            horizontal = true;
            btmrightflg = false;
        }

        public override void Movement()
        {
            base.Moving = true;

            int x = base.Location.X;
            int y = base.Location.Y;

            //Generating speed
            if (horizontal)
            {
                if (btmrightflg)
                {
                    speedX = -(Speed + randm.Next(0, 40));
                    speedY = 0;
                }
                else
                {
                    speedX = Speed + randm.Next(0, 40);
                    speedY = 0;
                }

            }
            else
            {
                if (btmrightflg)
                {
                    speedX = 0;
                    speedY = -(Speed + randm.Next(0, 40));
                }
                else
                {
                    speedX = 0;
                    speedY = Speed + randm.Next(0, 40);
                }
            }

            //Moving
            x += speedX;
            y += speedY;

            //Turning upon collision
            if (x + base.Size.Width >= Form1.formSizeW)
            {
                if (y <= 0)
                {
                    horizontal = true;
                    btmrightflg = true;
                    this.Image = Properties.Resources.cat_down;
                    y = 0;
                }
                else
                {
                    horizontal = false;
                    btmrightflg = true;
                    this.Image = Properties.Resources.cat_left;
                    x = Form1.formSizeW - base.Size.Width;
                }
            }
            else if (x <= 0)
            {
                if (y + base.Size.Height >= Form1.formSizeH)
                {
                    horizontal = true;
                    btmrightflg = false;
                    this.Image = Properties.Resources.cat_up;
                    y = Form1.formSizeH - base.Size.Height;
                }
                else
                {
                    horizontal = false;
                    btmrightflg = false;
                    this.Image = Properties.Resources.cat_right;
                    x = 0;
                }

            }

            base.Location = new Point(x, y);
        }

        public override int Hit()
        {
            base.Visible = false;
            Moving = false;

            Score += 2;
            return Score;
        }
    }
}
