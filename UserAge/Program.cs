using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsib kasutaja vanust;
            //arvutab kasutaja sünniaasta;
            //kuvab sünniaasta;

            Console.WriteLine("Palun sisestage oma vanus.");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - UserAge;

            if(UserAge >= 80)
            {
                if (YearOfBirth <= 0)
                {
                    Console.WriteLine("Olete Kõikvõimas ja surematu!");
                }
                else
                {
                    Console.WriteLine($"Olete sündinud {YearOfBirth}. aastal.");
                    Console.WriteLine($"Olete elanud keskmisest inimesest kauem!");
                }
            }
            else
            {
                Console.WriteLine($"Olete sündinud {YearOfBirth}. aastal.");
            }
            
            
        }
    }
}
