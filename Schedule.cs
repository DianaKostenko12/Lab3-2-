using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2_
{
    public class Schedule
    {
        public List<Record> Subjects { get; set; }

        public Schedule(List<Record> subjects)
        {
            Subjects = subjects;
        }

        public void Records(DayOfWeek day)
        {
            Console.Clear();
            var time = Subjects.Where(x => x.DayOfWeekDayOfWeek ==day).ToList();
            if (time.Count == 0)
            {
                Console.WriteLine("В даний день немає пар");
            }
            else
            {
                Console.WriteLine("Розклад на цей день: ");
                foreach (var record in time)
                {
                    Console.WriteLine($"{record.StartTime} - {record.EndTime} {record.Place} {record.Subject}");
                }
            }
        }

        public void Clear(DayOfWeek day)
        {
            Console.Clear();
            var times = Subjects.Where(x => x.DayOfWeekDayOfWeek == day).ToList();
            times.Clear();
        }

        public void Add(Record subject, DayOfWeek day)
        {
            var times = Subjects.Where(x => x.DayOfWeekDayOfWeek == day).ToList();
            //for (int i = 0; i < time.Count; i++)
            //{
            //    if (time[i].StartTime == subject.StartTime)
            //    {
            //        Console.WriteLine("На цей час є iнша пара");
            //    }
            //    else
            //    {
            //        Subjects.Add(subject);
            //    }
            //}

            foreach (var time in times)
            {
                if(time.StartTime == subject.StartTime)
                {
                    Console.WriteLine("На цей час є iнша пара");
                }
                else
                {
                    Subjects.Add(subject);
                }
               
            }
            foreach (var item in Subjects)
            {
                Console.WriteLine($"{item.StartTime} - {item.EndTime} {item.Place} {item.Subject}");
            }

        }

        public void Replace(Record subject, DayOfWeek day)
        {
            var time = Subjects.Where(x => x.DayOfWeekDayOfWeek == day).ToList();
            Console.WriteLine("Розклад на цей день: ");
            foreach (var record in time)
            {
                Console.WriteLine($"{record.StartTime} - {record.EndTime} {record.Place} {record.Subject}");
            }
            Console.WriteLine("Введiть номер запису, який ви хочете замiнити: ");
            int index = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < time.Count; i++)
            {
                if(index == i)
                {
                    time[i] = subject;
                }
                else 
                {
                    Console.WriteLine("Немає запису під цим номером");
                }
                Console.WriteLine($"{time[i].StartTime} - {time[i].EndTime} {time[i].Place} {time[i].Subject}");
            }

        }
        public void Remove(DayOfWeek day)
        {
            var time = Subjects.Where(x => x.DayOfWeekDayOfWeek == day).ToList();
            Console.WriteLine("Розклад на цей день: ");
            foreach (var record in time)
            {
                Console.WriteLine($"{record.StartTime} - {record.EndTime} {record.Place} {record.Subject}");
            }

            Console.WriteLine("Введiть номер запису, який ви хочете видалити: ");
            int index = Convert.ToInt32(Console.ReadLine());

            time.RemoveAt(index);
            foreach (var record in time)
            {
                Console.WriteLine($"{record.StartTime} - {record.EndTime} {record.Place} {record.Subject}");
            }
        }

        public void Insert( Record subject, DayOfWeek day) 
        {
            var time = Subjects.Where(x => x.DayOfWeekDayOfWeek == day).ToList();

            foreach (var record in time)
            {
                Console.WriteLine($"{record.StartTime} - {record.EndTime} {record.Place} {record.Subject}");
            }

            Console.WriteLine("Введiть номер запису, куди ви хочете вставити: ");
            int index = Convert.ToInt32(Console.ReadLine());

            time.Insert(index, subject);
            foreach (var record in time)
            {
                Console.WriteLine($"{record.StartTime} - {record.EndTime} {record.Place} {record.Subject}");
            }
        }

        public void Duration(string choosenPlace)
        {
            var places = Subjects.Where(x => x.Place == choosenPlace).ToList();
            foreach (var place in places)
            {
                Console.WriteLine($"Тривалiсть: {place.EndTime - place.StartTime }" +
                    $" {place.Place} {place.Subject}");
            }
        }
        public void StartTime(string choosenPlace) 
        {
            var places = Subjects.Where(x => x.Place == choosenPlace).ToList();
            foreach (var place in places)
            {
                Console.WriteLine($"Початок: {place.StartTime}" +
                    $" {place.Place} {place.Subject}");
            }
        }
    }
}
