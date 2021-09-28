using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestage oma sünniaasta.");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - YearOfBirth;

            if(UserAge <= 23)
            {
                if(UserAge >= 21)
                {
                    Console.WriteLine("Palju õnne! Saate taotleda järgmisi juhtimisõiguse kategooriad: A2; A-kategooria sümmeetrilise rataste asetusega kolmerattaline mootorsõiduk, mille mootori võimsus ületab 15 kW; B; C; D1");
                }else if(UserAge >= 20)
                {
                    Console.WriteLine("Palju õnne! Saate taotleda järgmisi juhtimisõiguse kategooriaid: A2; A-kategooria, juhul kui A2-kategooria on olnud vähemalt kaks aastat; B; C1.");
                }else if(UserAge >= 18)
                {
                    Console.WriteLine("Palju õnne! Saate taotleda järgmisi juhtimisõiguse kategooriaid: A2; B; C1");
                }else if(UserAge >= 16)
                {
                    Console.WriteLine("Palju õnne! Saate taotleda järgmisi juhtimisõiguse kategooriad: A1; B (sõiduki juhtimine lubatud ainult koos isikuga, kellel on vähemalt B-kategooria olnud kaks aastat).");
                }else if(UserAge >= 14)
                {
                    Console.WriteLine("Palju õnne! Saate taotleda ainult AM-kategooria juhtimisõigust.");
                }
                else
                {
                    Console.WriteLine("Olete liiga noor juhtimisõiguse taotlemiseks.");
                }
            }
            else
            {
                Console.WriteLine("Palju õnne! Võid taotleda kõiki juhtimisõiguse kategooriaid.");
            }
        }
    }
}
