using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warikan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double tax = 0.08;
            double amount;
            int perperson;
            int people;
            int remainder;

            amount = int.Parse(textBoxPretax.Text);
            people = int.Parse(textBoxPpl.Text);
            amount *= 1 + tax;
            perperson = (int)amount / people;
            remainder = (int)amount % people;
            labelPerperson.Text = perperson + " 円";
            labelRemainder.Text = remainder + " 円";
        }
    }
}
