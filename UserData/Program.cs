using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsib kautaja sünniaastat;
            //arvutab kasutaja vanuse;
            //kuvab kasutaja vanuse;

            Console.WriteLine("Palun sisestage oma sünniaasta:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - YearOfBirth;
            //Console.WriteLine("Olete " + UserAge + " aastat vana.");

            Console.WriteLine($"Oled {UserAge} aastat vana.");

        }
    }
}
