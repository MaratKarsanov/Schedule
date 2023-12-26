using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public class Schedule
    {
        public string FacultyName { get; }
        public List<Lesson> ListLesson;
        public Schedule(string facultyName)
        {
            ListLesson = new List<Lesson>();
            FacultyName = facultyName;
        }

        public void Add(Lesson lesson)
        {
            ListLesson.Add(lesson);
        }

        public override string ToString()
        {
            var res = new StringBuilder();
            for (var i = 0; i < ListLesson.Count; i++)
                res.Append((i + 1) + ". " + ListLesson[i].ToString() + "\n");
            return res.ToString();
        }

        public IEnumerable<Lesson> Sort()
        {
            var res = ListLesson
                .OrderBy(l => l.WeekDay)
                .ThenBy(l => l.Number);
            return res;
        }

        public IEnumerable<Lesson> Sort(Func<Lesson, IEnumerable<Lesson>> selector)
        {
            var res = ListLesson
                .OrderBy(selector);
            return res;
        }
    }
}
