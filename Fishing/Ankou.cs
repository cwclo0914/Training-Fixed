using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Ankou : Fish
    {
        //Constructors
        public Ankou(int positionX, int positionY, double speed, int destinationX, System.Windows.Forms.PictureBox picture)
            : base(positionX, positionY, speed, destinationX, picture)
        {

        }
    }
}
