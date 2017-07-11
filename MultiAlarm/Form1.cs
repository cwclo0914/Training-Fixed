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
    public partial class Form1 : Form
    {
        private bool[] alarmSetFlag = { false, false, false };
        private int[] alarmHour = { 0, 0, 0 };
        private int[] alarmMinute = { 0, 0, 0 };
        private int[] alarmSecond = { 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("T");

            //Alarm
            for (int i = 0; i <= 2; i++)
            {
                if (alarmSetFlag[i] == true &&
                    alarmHour[i] == now.Hour &&
                    alarmMinute[i] == now.Minute &&
                    alarmSecond[i] == now.Second)
                {
                    alarmSetFlag[i] = false;
                    MessageBox.Show("時間です！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (i == 0)
                    {
                        checkBox1.Checked = false;
                        checkBox1.Text = "00:00";
                    }
                    else if (i == 1)
                    {
                        checkBox2.Checked = false;
                        checkBox2.Text = "00:00";
                    }
                    else if (i == 2)
                    {
                        checkBox1.Checked = false;
                        checkBox1.Text = "00:00";
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 alarm1 = new MultiAlarm.Form2();
            if (alarm1.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag[0] = true;
                alarmHour[0] = alarm1.alarmHour;
                alarmMinute[0] = alarm1.alarmMinute;
                alarmSecond[0] = alarm1.alarmSecond;
                checkBox1.Text = alarmHour[0].ToString("00") + ":" + alarmMinute[0].ToString("00");
                checkBox1.Checked = true;
            }
            alarm1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 alarm2 = new MultiAlarm.Form2();
            if (alarm2.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag[1] = true;
                alarmHour[1] = alarm2.alarmHour;
                alarmMinute[1] = alarm2.alarmMinute;
                alarmSecond[1] = alarm2.alarmSecond;
                checkBox2.Text = alarmHour[1].ToString("00") + ":" + alarmMinute[1].ToString("00");
                checkBox2.Checked = true;
            }
            alarm2.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 alarm3 = new MultiAlarm.Form2();
            if (alarm3.ShowDialog() == DialogResult.OK)
            {
                alarmSetFlag[2] = true;
                alarmHour[2] = alarm3.alarmHour;
                alarmMinute[2] = alarm3.alarmMinute;
                alarmSecond[2] = alarm3.alarmSecond;
                checkBox3.Text = alarmHour[2].ToString("00") + ":" + alarmMinute[2].ToString("00");
                checkBox3.Checked = true;
            }
            alarm3.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            alarmSetFlag[0] = !alarmSetFlag[0];
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            alarmSetFlag[1] = !alarmSetFlag[1];
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            alarmSetFlag[2] = !alarmSetFlag[2];
        }
    }
}
