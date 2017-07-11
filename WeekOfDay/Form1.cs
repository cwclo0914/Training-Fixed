using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int year, month, date, day;
            year = (int)numericUpDownYear.Value;
            month = (int)numericUpDownMonth.Value;
            date = (int)numericUpDownDate.Value;

            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    if (date > 30)
                    {
                        labelDay.Text = "あり得ない日付";
                        return;
                    }
                    else break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (date > 31)
                    {
                        labelDay.Text = "あり得ない日付";
                        return;
                    }
                    else break;
                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                    {
                        if (date > 29)
                        {
                            labelDay.Text = "あり得ない日付";
                            return;
                        }
                        else break;
                    }
                    else
                    {
                        if (date > 28)
                        {
                            labelDay.Text = "あり得ない日付";
                            return;
                        }
                        else break;
                    }
            }

            day = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + date) % 7;

            switch (day)
            {
                case 0:
                    labelDay.Text = "日曜日です";
                    break;
                case 1:
                    labelDay.Text = "月曜日です";
                    break;
                case 2:
                    labelDay.Text = "火曜日です";
                    break;
                case 3:
                    labelDay.Text = "水曜日です";
                    break;
                case 4:
                    labelDay.Text = "木曜日です";
                    break;
                case 5:
                    labelDay.Text = "金曜日です";
                    break;
                case 6:
                    labelDay.Text = "土曜日です";
                    break;
            }
        }
    }
}
