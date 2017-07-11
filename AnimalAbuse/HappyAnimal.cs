using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnimalAbuse
{
    abstract class HappyAnimal : PictureBox
    {
        public HappyAnimal(int originX, int originY, int speed, Image image)
        {
            base.Location = new Point(originX, originY);
            OriginX = originX;
            OriginY = originY;
            Speed = speed;
            Moving = false;
            base.Image = image;
            base.SizeMode = PictureBoxSizeMode.AutoSize;
            base.BackColor = Color.Transparent;
        }

        //Properties
        public static int Score { get; set; }
        public int OriginX { get; private set; }
        public int OriginY { get; private set; }
        public int Speed { get; protected set; }
        public bool Moving { get; set; }

        //Methods
        public abstract void Appear();
        public abstract void Movement();
        public abstract int Hit();
    }
}
