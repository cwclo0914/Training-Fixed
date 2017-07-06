using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //On Click event for 'OK' button
        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelMsg.Text = textBoxName.Text + "さん、こんにちは。";
        }
    }
}
