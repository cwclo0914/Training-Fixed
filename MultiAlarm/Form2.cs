using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class Form2 : Form
    {
        internal int alarmHour = 0;
        internal int alarmMinute = 0;
        internal int alarmSecond = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDownHr.Value = DateTime.Now.Hour;
            numericUpDownMin.Value = DateTime.Now.Minute;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDownHr.Value;
            alarmMinute = (int)numericUpDownMin.Value;
            alarmSecond = 0;
        }
    }
}
