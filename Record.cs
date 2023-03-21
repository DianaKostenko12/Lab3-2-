using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2_
{
    public class Record
    {
        public DayOfWeek DayOfWeekDayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Subject { get; set; }
        public string Place { get; set; }
        public Record(DayOfWeek dayOfWeek, TimeSpan startTime, TimeSpan endTime, string subject, string place)
        {
            this.DayOfWeekDayOfWeek = dayOfWeek;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Subject = subject;
            this.Place = place;
        }
    }
}
