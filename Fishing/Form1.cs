using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class Form1 : Form
    {
        bool dayflg = true;
        int daycnt = 0;
        bool nightflg = false;
        int nightcnt = 0;
        bool startflg = false;
        double timeleft = 60.00;
        int score = 0;
        double fps = 10;
        Ankou ankou;
        Iwashi iwashi;
        Utubo utubo;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;

            //Ankou
            int x = pictureBoxAnkou.Location.X;
            int y = pictureBoxAnkou.Location.Y;
            ankou = new Ankou(x, y, 100/fps, formSizeW, pictureBoxAnkou);

            //Iwashi
            x = pictureBoxIwashi.Location.X;
            y = pictureBoxIwashi.Location.Y;
            iwashi = new Iwashi(x, y, 200/fps, formSizeW, pictureBoxIwashi);

            //Utubo
            x = pictureBoxUtubo.Location.X;
            y = pictureBoxUtubo.Location.Y;
            utubo = new Utubo(x, y, 100/fps, formSizeW, pictureBoxUtubo);
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!startflg)
            {
                timeleft = 60.00;
                score = 0;
            }
            timer1.Start();
            startflg = true;
  //          buttonStart.Enabled = false;
        }
        private void swim()
        {
            int x, y;

            ankou.Swim(out x, out y);
            ankou.PictureMove(x, y);
            iwashi.Swim(out x, out y);
            iwashi.PictureMove(x, y);
            utubo.Swim(out x, out y);
            utubo.PictureMove(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            swim();
            if (timeleft > 0)
            {
                timeleft = timeleft - 1.0/fps;
                labelTime.Text = ((int)timeleft).ToString() + "秒";
                if (dayflg)
                {
                    if (daycnt < 10 * fps)
                    {
                        daycnt++;
                    }
                    else
                    {
                        dayflg = false;
                        nightflg = true;
                        iwashi.Sleep();
                        utubo.Sleep();
                        this.BackColor = Color.DarkBlue;
                        daycnt = 0;
                    }
                }
                else if (nightflg)
                {
                    if (nightcnt < 5 * fps)
                    {
                        nightcnt++;
                    }
                    else
                    {
                        dayflg = true;
                        nightflg = false;
                        iwashi.Wakeup();
                        utubo.Wakeup();
                        this.BackColor = Color.LightBlue;
                        nightcnt = 0;
                    }
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("時間です。", "終了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelTime.Text = "0秒";
                startflg = false;
    //            buttonStart.Enabled = true;
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                int point = int.Parse(e.KeyChar.ToString());
                score += ankou.Eat(point, pictureBoxBaitM);
                score += iwashi.Eat(point, pictureBoxBaitS);
                score += utubo.Eat(point, pictureBoxBaitL);

                labelScore.Text = score.ToString();
            }
        }
    }
}
