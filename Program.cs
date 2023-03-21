using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Lab_3_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule1 = new Schedule(new List<Record>()
            {
                new Record(DayOfWeek.Monday, new TimeSpan(8, 30, 0),  new TimeSpan(10, 5, 0),"Фiзика","Каб 18"),
                new Record(DayOfWeek.Monday, new TimeSpan(10, 25, 0),  new TimeSpan(12, 0, 0),"Теорiя алгоритмiв","Каб 19"),
                new Record(DayOfWeek.Thursday, new TimeSpan(8, 30, 0),  new TimeSpan(10, 5, 0),"Англ мова","Каб 18"),
                new Record(DayOfWeek.Thursday, new TimeSpan(10, 25, 0),  new TimeSpan(12, 0, 0),"Укр мова","Каб 17"),
                new Record(DayOfWeek.Thursday,new TimeSpan(12, 20, 0),  new TimeSpan(13, 50, 0),"ОЗСЖ","Каб 20"),
                new Record(DayOfWeek.Wednesday, new TimeSpan(8, 30, 0),  new TimeSpan(10, 5, 0),"Чисельнi методи","Каб 18"),
                new Record(DayOfWeek.Wednesday, new TimeSpan(10, 25, 0),  new TimeSpan(12, 0, 0),"Вишмат","Каб 19"),
                new Record(DayOfWeek.Tuesday, new TimeSpan(10, 25, 0),  new TimeSpan(12, 0, 0),"Програмування","Каб 19"),
                new Record(DayOfWeek.Friday, new TimeSpan(10, 25, 0),  new TimeSpan(12, 0, 0),"Фізика","Каб 18"),
            });
            Console.WriteLine("Що ви хочете зробити? \n 1 - Подивитися записи \n 2 - Очистити розклад \n 3 - Додати новий запис" +
                "\n 4 - Замiнити iснуючий \n 5 - Видалити \n 6 - Вставити \n 7 - Подивитися час початку \n 8 - Тривалiсть  ");
            int choose = Convert.ToInt32(Console.ReadLine());
            string choosenPlace;
            switch (choose) 
            {
                case 1:
                    schedule1.Records(Template());
                    break;
                case 2:
                    schedule1.Clear(Template());
                    break;
                case 3:
                    schedule1.Add(NewRecord(Template()), Template());
                    break;
                case 4:
                    schedule1.Replace(NewRecord(Template()), Template());
                    break;
                case 5:
                    schedule1.Remove(Template());
                    break;
                case 6:
                    schedule1.Insert(NewRecord(Template()), Template());
                    break;
                case 7:
                    choosenPlace= Console.ReadLine();
                    schedule1.StartTime(choosenPlace);
                    break;
                case 8:
                    choosenPlace = Console.ReadLine();
                    schedule1.Duration(choosenPlace);
                    break;

            }
            static DayOfWeek Template()
            {
                Console.WriteLine("Вкажiть день тижня:\nПонедiлок - 1\nВiвторок - 2 \nСереда - 3\nЧетвер - 4\nП'ятниця - 5 ");
                return (DayOfWeek)Convert.ToInt32(Console.ReadLine());
            }

            static Record NewRecord(DayOfWeek day)
            {
                Console.Clear();
                Console.WriteLine("Введiть час початку: ");
                TimeSpan startTime = new TimeSpan(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Введiть час закiнчення: ");
                TimeSpan endTime = new TimeSpan(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Введiть назву предмету : ");
                string choosenSubject = Console.ReadLine();

                Console.WriteLine("Введiть мiсце проведення : ");
                string place = Console.ReadLine();
                return new Record(day, startTime, endTime, choosenSubject, place);
            }

            //schedule1.Add(subject);

            //Console.WriteLine("Введiть iндекс, елемента якого б хотiла видалити: ");
            //int index = Convert.ToInt32(Console.ReadLine());
            ////schedule1.Replace(index, subject);
            //schedule1.Remove(index);
            //schedule1.Insert(index, subject);
            //schedule1.Duration();
        }
    }
}
