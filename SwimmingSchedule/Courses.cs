using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class Courses
    {
        //Fields
        private int day;
        private int time;
        private int fee;

        //Constructors
        public Courses(int day, int time, int fee)
        {
            Day = day;
            Time = time;
            Fee = fee;
        }

        //Properties
        public int Day { get; set; }
        public int Time { get; set; }
        public int Fee { get; set; }
    }
}
