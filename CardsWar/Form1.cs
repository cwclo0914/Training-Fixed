using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsWar
{
    public partial class Form1 : Form
    {
        private Card[] playingCards;
        private Player player;
        private Computer computer;
        private int cc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createCards(ref playingCards);

            player = new Player();
            computer = new Computer();
            cc = 0;

            SuspendLayout();
            const int offsetX = 140, offsetY = 30;
            for (int i = 0; i < playingCards.Length; i++)
            {
                playingCards[i].Name = "card" + i;
                int sizeW = playingCards[i].Size.Width;
                int sizeH = playingCards[i].Size.Height;
                playingCards[i].Location = new Point(offsetX + i % 13 * sizeW, offsetY + i / 13 * (sizeH + 120));

                playingCards[i].Click += new EventHandler(cardButtons_Click);
            }

            Controls.AddRange(playingCards);
            ResumeLayout(false);

            labelComment.Text = "カードを選んでください。";
        }

        private void createCards(ref Card[] cards)
        {
            string[] number = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            cards = new Card[number.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++)
            {
                cards[i] = new Card(number[j]);
                cards[i + 1] = new Card(number[j]);
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            shuffleCard(playingCards);
            player.Reset();
            computer.Reset();

            foreach (Card c in playingCards)
            {
                c.Close();
            }

            for (int i = 0; i < 13; i++)
            {
                playingCards[i].Enabled = false;
            }

            buttonStart.Enabled = false;
        }

        private void shuffleCard(Card[] cards)
        {
            Random randn = new Random();

            int n = cards.Length - 1;
            while (n > 0)
            {
                int k = randn.Next(0, n);
                string temp = cards[k].Number;
                cards[k].Number = cards[n].Number;
                cards[n].Number = temp;
                n--;
            }
        }

        private void cardButtons_Click(object sender, EventArgs e)
        {
            int pc = int.Parse(((Button)sender).Name.Substring(4));
            playingCards[pc].Open();
            if (player.CurrentOpenCardIndex != -1)
            {
                player.ToPrevious();
                playingCards[player.PreviousOpenCardIndex].Opened();
            }
            player.CurrentOpenCardIndex = pc;

            if (computer.CurrentOpenCardIndex != -1)
            {
                computer.ToPrevious();
                playingCards[computer.PreviousOpenCardIndex].Opened();
            }

            playingCards[computer.Draw()].Open();
            cc = computer.CurrentOpenCardIndex;

            dual(playingCards, pc, cc);

            labelPlayerScore.Text = "得点：" + player.Score;
            labelCpuScore.Text = "得点：" + computer.Score;

            if (allOpenCheck(playingCards))
            {
                if (player.Score > computer.Score)
                    labelComment.Text = "プレーヤーが勝ちました。おめでとうございます。";
                else if (player.Score < computer.Score)
                    labelComment.Text = "コンピューターが勝ちました。残念です。";
                else
                    labelComment.Text = "引き分けでした。お疲れ様でした。";

                buttonStart.Enabled = true;
            }

        }

        private void dual(Card[] cards, int pindex, int cindex)
        {
            int pscore = 0;
            int cscore = 0;

            string[] numbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int[] scores = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == cards[pindex].Number)
                    pscore = scores[i];
                if (numbers[i] == cards[cindex].Number)
                    cscore = scores[i];
            }

            if (pscore > cscore)
            {
                player.Score += 2;
                labelComment.Text = "プレーヤーが勝ちました。次のカードを選んでください。";
            }

            else if (pscore < cscore)
            {
                computer.Score += 2;
                labelComment.Text = "コンピューターが勝ちました。次のカードを選んでください。";
            }
            else
            {
                player.Score += 1;
                computer.Score += 1;
                labelComment.Text = "引き分けでした。次のカードを選んでください。";
            }
        }

        private bool allOpenCheck(Card[] cards)
        {
            for (int i = 13; i < cards.Length; i++)
            {
                if (cards[i].State == false)
                    return false;
            }
            return true;
        }
    }
}
