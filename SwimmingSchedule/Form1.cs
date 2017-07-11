using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchedule
{
    public partial class Form1 : Form
    {
        //Variables
        private int year = DateTime.Now.Year;
        private int month = DateTime.Now.Month;

        //Instances
        Courses[] course = new Courses[7];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownYear.Value = (decimal)year;
            numericUpDownMonth.Value = (decimal)month;

            course[0] = new Courses(1, 14, 1000);
            course[1] = new Courses(2, 10, 1000);
            course[2] = new Courses(3, 17, 800);
            course[3] = new Courses(4, 19, 800);
            course[4] = new Courses(5, 20, 1000);
            course[5] = new Courses(6, 20, 1200);
            course[6] = new Courses(0, 10, 1500);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int n = listBoxCourse.SelectedIndex;
            int date;
            int day;
            int count = 0;
            string ds = "";

            year = (int)numericUpDownYear.Value;
            month = (int)numericUpDownMonth.Value;
            
            for (date = 1; date <= DateTime.DaysInMonth(year, month) - 3; date++)
            {
                DateTime dt = new DateTime(year, month, date);
                day = (int)dt.DayOfWeek;
                if (day == course[n].Day)
                {
                    ds = ds + date.ToString() + "日 ";
                    count++;
                }
            }
            labelDate.Text = ds;
            labelTime.Text = course[n].Time + "時";
            labelFee.Text = course[n].Fee * count + "円";
        }
    }
}
