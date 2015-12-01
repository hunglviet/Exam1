using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Question2
    {


        public static void sign()
        {
            //Input a birthdate
            int date, month, year;
            Console.WriteLine("Enter your day of birth");
            date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your month of birth");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your year of birth");
            year = Convert.ToInt32(Console.ReadLine());

            DateTime birthdate = new DateTime(year, month, date);


            //Check old is not less than 0 and not larger than 135 year old
            DateTime now = DateTime.Now;
            if (birthdate > now || (now.Year - birthdate.Year) > 135)
            {
                Console.WriteLine("Oh! Oh! Your are larger than 135 year old! I'm not sure!");
            }
            else
            {
                Console.WriteLine("Your birthday {0}", birthdate);
                Console.WriteLine("Your are {0} year old", (now.Year - birthdate.Year));



            }
            //You are belong sign


            //1.Aries(21 / 3 - 19 / 4) Bạch Dương
            DateTime Aries1 = new DateTime(birthdate.Year, 3, 21);
            DateTime Aries2 = new DateTime(birthdate.Year, 4, 19);

            if (DateTime.Compare(birthdate,Aries1) >= 0 & DateTime.Compare(birthdate,Aries2) <=0)
            {
                Console.WriteLine("You are belong Aries");
            }

            //2.Taurus(20 / 4 - 20 / 5) Kim Ngưu
            DateTime Taurus1 = new DateTime(birthdate.Year, 4, 20);
            DateTime Taurus2 = new DateTime(birthdate.Year, 5, 20);

            if (DateTime.Compare(birthdate, Taurus1) >= 0 & DateTime.Compare(birthdate, Taurus2) <= 0)
            {
                Console.WriteLine("You are belong Taurius");
            }

            //3.Gemini(21 / 5 - 21 / 6) Song Tử
            DateTime Gemini1 = new DateTime(birthdate.Year, 5, 21);
            DateTime Gemini2 = new DateTime(birthdate.Year, 6, 21);

            if (DateTime.Compare(birthdate, Gemini1) >= 0 & DateTime.Compare(birthdate, Gemini2) <= 0)
            {
                Console.WriteLine("You are belong Gemini");
            }

            //4.Cancer(22 / 6 - 22 / 7) Cự Giải
            DateTime Cancer1 = new DateTime(birthdate.Year, 6, 22);
            DateTime Cancer2 = new DateTime(birthdate.Year, 7, 22);
            if (DateTime.Compare(birthdate, Cancer1) >= 0 & DateTime.Compare(birthdate, Cancer2) <= 0)
            {
                Console.WriteLine("You are belong Cancer");
            }

            //5.Leo(23 / 7 - 22 / 8) Sư Tử
            DateTime Leo1 = new DateTime(birthdate.Year, 6, 22);
            DateTime Leo2 = new DateTime(birthdate.Year, 7, 22);

            if (DateTime.Compare(birthdate, Leo1) >= 0 & DateTime.Compare(birthdate, Leo2) <= 0)
            {
                Console.WriteLine("You are belong Leo");
            }

            //6.Virgo(23 / 8 - 22 / 9) Xử Nữ
            DateTime Virgo1 = new DateTime(birthdate.Year, 8, 23);
            DateTime Virgo2 = new DateTime(birthdate.Year, 9, 22);
            if (DateTime.Compare(birthdate, Virgo1) >= 0 & DateTime.Compare(birthdate, Virgo2) <= 0)
            {
                Console.WriteLine("You are belong Virgo");
            }

            //7.Libra(23 / 9 - 23 / 10) Thiên Bình
            DateTime Libra1 = new DateTime(birthdate.Year, 9, 23);
            DateTime Libra2 = new DateTime(birthdate.Year, 10, 23);

            if (DateTime.Compare(birthdate, Libra1) >= 0 & DateTime.Compare(birthdate, Libra2) <= 0)
            {
                Console.WriteLine("You are belong Libra");
            }

            //8.Scorpio(24 / 10 - 22 / 11) Hổ Cáp
            DateTime Scorpio1 = new DateTime(birthdate.Year, 10, 24);
            DateTime Scorpio2 = new DateTime(birthdate.Year, 11, 22);

            if (DateTime.Compare(birthdate, Scorpio1) >= 0 & DateTime.Compare(birthdate, Scorpio2) <= 0)
            {
                Console.WriteLine("You are belong Scorpio");
            }

            //9.Sagittarius(23 / 11 - 21 / 12) Nhân Mã
            DateTime Sagittarius1 = new DateTime(birthdate.Year, 11, 23);
            DateTime Sagittarius2 = new DateTime(birthdate.Year, 12, 21);

            if (DateTime.Compare(birthdate, Sagittarius1) >= 0 & DateTime.Compare(birthdate, Sagittarius2) <= 0)
            {
                Console.WriteLine("You are belong Sagittarius");
            }

            //10.Capricornus(22 / 12 - 19 / 1) Ma Kết
            DateTime Capricornus1 = new DateTime(birthdate.Year, 12, 22);
            DateTime Capricornus2 = new DateTime(birthdate.Year, 1, 19);

            if (DateTime.Compare(birthdate, Capricornus1) >= 0 & DateTime.Compare(birthdate, Capricornus2) <= 0)
            {
                Console.WriteLine("You are belong Capricornus");
            }

            //11.Aquarius(20 / 1 - 18 / 2) Bảo Bình
            DateTime Aquarius1 = new DateTime(birthdate.Year, 1, 20);
            DateTime Aquarius2 = new DateTime(birthdate.Year, 2, 18);

            if (DateTime.Compare(birthdate, Aquarius1) >= 0 & DateTime.Compare(birthdate, Aquarius2) <= 0)
            {
                Console.WriteLine("You are belong Aquarius");
            }

            //12.Pisces(19 / 2 - 20 / 3) Song Ngư
            DateTime Pisces1 = new DateTime(birthdate.Year, 2, 19);
            DateTime Pisces2 = new DateTime(birthdate.Year, 3, 20);

            if (DateTime.Compare(birthdate, Pisces1) >= 0 & DateTime.Compare(birthdate, Pisces2) <= 0)
            {
                Console.WriteLine("You are belong Pisces");
            }


           // Console.ReadLine();
        }

    }
}
