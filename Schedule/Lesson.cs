using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public class Lesson
    {
        private static Dictionary<string, string> WeekDaysOnRussian = new Dictionary<string, string>()
        {
            { "Sunday", "воскресенье" },
            { "Monday" , "понедельник" },
            { "Tuesday", "вторник" },
            { "Wednesday", "среда" },
            { "Thursday", "четверг" },
            { "Friday", "пятница" },
            { "Saturday", "суббота" }
        };
        private static Dictionary<int, string> WeekNumberOnRussian = new Dictionary<int, string>()
        {
            { 0, "каждую неделю" },
            { 1 , "первая неделя" },
            { 2, "вторая неделя" }
        };
        private static char CurrentName = 'A';
        public string Label { get; }
        public int Number { get; }
        public int WeekNumber { get; }
        public string GroupNumber { get; }
        public WeekDays WeekDay { get; }

        public Lesson()
        {
            var rnd = new Random();
            Label = CurrentName.ToString();
            Number = rnd.Next(1, 5);
            WeekNumber = rnd.Next(0, 3);
            GroupNumber = rnd.Next(11, 52).ToString();
            WeekDay = (WeekDays)rnd.Next(0, 7);
            if (CurrentName == 'Z')
                CurrentName = 'A';
            else
                CurrentName++;
        }

        public Lesson(string label, int number, int weekNumber, WeekDays weekDay, string groupNumber)
        {
            Label = label;
            Number = number;
            WeekNumber = weekNumber;
            GroupNumber = groupNumber;
            WeekDay = weekDay;
        }

        public override string ToString()
        {
            return Label + ", " + Number.ToString() + " пара " + WeekDaysOnRussian[WeekDay.ToString()] + ", " + GroupNumber + " группа, "
                + WeekNumberOnRussian[WeekNumber];
        }
    }
}
