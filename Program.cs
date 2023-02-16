using System;

namespace prr
{
    class Program
    {
        static void Main(string[] args)
        {
            string fio;

            int year, month, day;

            bool incorrect;

            Pacient pacient = new Pacient();


            do
            {
                incorrect = false;
                Console.Write("Введите инициалы пациента: ");
                fio = Console.ReadLine();
                Console.Write("Введите год рождения:\t");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите месяц рождения:\t");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите день рождения:\t");
                day = Convert.ToInt32(Console.ReadLine());

                if (fio.IndexOf(' ') < 0)
                {

                    Console.WriteLine("Неккоректные инициалы");

                    incorrect = true;

                }

                if (year < 1980)
                {
                    Console.WriteLine("Неккоректная дата");

                    incorrect = true;

                }

                {
                    try
                    {
                        pacient.DateOfBirth = new DateTime(year, month, day);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Некорректная дата");
                        incorrect = true;
                    }
                }
            }
            while (incorrect);


            int age = DateTime.Now.Year - pacient.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < pacient.DateOfBirth.DayOfYear)
                age--;
            Console.WriteLine("Возраст:\t\t{0}", age);
            
        }
    }
}
