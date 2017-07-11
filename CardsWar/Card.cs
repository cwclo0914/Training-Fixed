using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CardsWar
{
    class Card : Button
    {
        //Fields
        private const int sizeW = 50, sizeH = 70;
        private Color openCurrentColor = Color.White;
        private Color openPreviousColor = Color.Gray;
        private Color closeColor = Color.LightSeaGreen;

        //Constructors
        public Card(string number)
        {
            Number = number;
            State = false;
            base.Size = new Size(sizeW, sizeH);
            base.BackColor = closeColor;
            base.Font = new Font("MS UI Gothic", 14, FontStyle.Bold);
            base.Enabled = false;
        }

        //Properties
        public string Number { get; set; }

        public bool State { get; set; }

        //Methods
        public void Open()
        {
            State = true;
            base.BackColor = openCurrentColor;
            base.Text = Number;
            base.Enabled = false;            
        }

        public void Opened()
        {
            base.BackColor = openPreviousColor;
        }

        public void Close()
        {
            State = false;
            base.BackColor = closeColor;
            base.Text = "";
            base.Enabled = true;
        }

        public void Turn()
        {
            if (State == true)
                Close();
            else
                Open();
        }
    }
}
