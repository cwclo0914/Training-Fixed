using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlowerMeanings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (Flower.Get(textBoxName.Text, comboBoxColour.Text) != null)
            {
                if (comboBoxColour.Text == "")
                    MessageBox.Show(textBoxName.Text + "の花言葉は" + Flower.Get(textBoxName.Text, comboBoxColour.Text) + "です。", "花言葉");
                else
                    MessageBox.Show(textBoxName.Text + "(" + comboBoxColour.Text + ")の花言葉は" + Flower.Get(textBoxName.Text, comboBoxColour.Text) + "です。", "花言葉");
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2.Dispose();
        }
    }
}
