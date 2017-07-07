using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalAbuse
{
    public partial class Form1 : Form
    {
        private HappyAnimal[] happyAnimal;
        private int timeLeft;

        private Random random;
        private int counter;

        public static int formSizeH;
        public static int formSizeW;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();

            happyAnimal = new HappyAnimal[61];
            timeLeft = 60;
            counter = 0;

            //Form size
            formSizeH = ClientSize.Height;
            formSizeW = ClientSize.Width;

        }



        private void timerAppear_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            labelTimeLeft.Text = timeLeft + "秒";

            if (timeLeft > 0)
            {
                happyAnimal[counter].Appear();
                counter++;
            }
            else if (timeLeft == 0)
            {
                timerAppear.Stop();
                timerMove.Stop();

                labelTimeLeft.Text = "終了";

                foreach (HappyAnimal obj in happyAnimal)
                {
                    obj.Visible = false;
                    obj.Moving = false;
                }

                buttonStart.Enabled = true;
            }
            
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < happyAnimal.Length; i++)
            {
                if (happyAnimal[i].Visible == true)
                {
                    happyAnimal[i].Movement();
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Animal Initialisation
            initialise(ref happyAnimal);

            buttonStart.Enabled = false;
            timeLeft = 60;
            counter = 0;
            HappyAnimal.Score = 0;
            labelScore.Text = "0";
            labelTimeLeft.Text = timeLeft + "秒";

            timerAppear.Start();
            timerMove.Start();
        }

        private void happyAnimal_Click(object sender, EventArgs e)
        {
            int n = int.Parse(((PictureBox)sender).Name.Substring(6));

            int score = happyAnimal[n].Hit();
            labelScore.Text = score.ToString();
        }

        private void initialise(ref HappyAnimal[] happyAnimal)
        {
            SuspendLayout();

            for (int i = 0; i < happyAnimal.Length; i++)
            {
                switch (random.Next(0, 4))
                {
                    case 0: //Bird
                        happyAnimal[i] = new Bird(0, 0, 5);
                        happyAnimal[i].Visible = false;
                        happyAnimal[i].Name = "animal" + i.ToString();
                        happyAnimal[i].Click += new EventHandler(happyAnimal_Click);
                        break;
                    case 1: //Rabbit
                        happyAnimal[i] = new Rabbit(0, formSizeH - Properties.Resources.rabbit.Height, 5);
                        happyAnimal[i].Visible = false;
                        happyAnimal[i].Name = "animal" + i.ToString();
                        happyAnimal[i].Click += new EventHandler(happyAnimal_Click);
                        break;
                    case 2: //Cat
                        happyAnimal[i] = new Cat(0, formSizeH - Properties.Resources.cat_up.Height, 10);
                        happyAnimal[i].Visible = false;
                        happyAnimal[i].Name = "animal" + i.ToString();
                        happyAnimal[i].Click += new EventHandler(happyAnimal_Click);
                        break;
                    case 3: //Mole
                        happyAnimal[i] = new Mole(formSizeW - Properties.Resources.mole.Width, formSizeH - (Properties.Resources.mole.Height) * 2 / 3, 0);
                        happyAnimal[i].Visible = false;
                        happyAnimal[i].Name = "animal" + i.ToString();
                        happyAnimal[i].Click += new EventHandler(happyAnimal_Click);
                        break;
                }
            }

            Controls.AddRange(happyAnimal);
            ResumeLayout(false);
        }

    }
}
