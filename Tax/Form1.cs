using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount;

            try
            {
                amount = int.Parse(textBoxPretax.Text);
                amount = addTax(amount);
                labelAftertax.Text = amount + " 円";
            }
            catch(FormatException ex)
            {
                labelAftertax.Text = ex.Message;
            }
        }

        private int addTax(int m)
        {
            const double tax = 0.08;

            return (int)(m * (1 + tax));
        }
    }
}
