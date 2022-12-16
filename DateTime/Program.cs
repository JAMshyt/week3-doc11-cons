using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба7
{
    class Date
    {
        public DateTime date;
        
        public Date()
        {
            
            do
            {
                Console.Write("Введите дату(дд.мм.гггг): ");
                if (DateTime.TryParse(Console.ReadLine(), out date))
                {
                    DateTime data = new DateTime(2009,01,1);
                    Console.WriteLine(data.ToString("d.MM.yyyy"));
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }

            }
            while (true);
        }

        public void days()
        {
            DateTime now = date;
            DateTime yesterday = now.AddDays(-1);
            DateTime tomorrow = now.AddDays(1);
            int daysLeft = DateTime.DaysInMonth(now.Year, now.Month) - now.Day;
            Console.Write(" "
                + "\nВчера: " + yesterday.ToString("dd.MM.yyyy")
                + "\nЗавтра: " + tomorrow.ToString("dd.MM.yyyy")
                + "\nОсталось дней до конца месяца: " + daysLeft);
        }
        public int leapYear
        {
            get
            {
                int year;
                do
                {
                    Console.Write("Введите год:");
                    if (Int32.TryParse(Console.ReadLine(), out year))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                }
                while (true);
                return year;
            }
            set
            {
                leapYear = 0;
            }
        }
        public string leap
        {
            get
            {
                string yes;
                bool lea = DateTime.IsLeapYear(leapYear);
                if (lea == true) { yes = "Высокосный"; } else { yes = "Не высокосный"; }
                return yes;
            }
        }
        public void knowLeap()
        {
            Console.Write("" + leap);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Date d = new Date();
                Console.WriteLine("");
                d.days();
                Console.WriteLine("\n");
                try
                {
                    d.knowLeap();
                    Console.WriteLine("\n");
                }
                catch { Console.WriteLine("год ддолжен быть >0"); }
            }
        }
    }
}
