using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestage oma sünniaasta.");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - YearOfBirth;

            if(UserAge <= 12)
            {
                Console.WriteLine("Olete liiga noor Instagrami kasutamiseks.");
            }
            else
            {
                Console.WriteLine("Võite kasutada Instagrami.");
            }
        }
    }
}
