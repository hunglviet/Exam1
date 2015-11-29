using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {

            int keyboard;

            do
            {
                Console.WriteLine("Please input number below to continue");
                Console.WriteLine("1--Exam about array");
                Console.WriteLine("2--Your birthday");
                Console.WriteLine("3--Quit program");
                keyboard = Convert.ToInt32(Console.ReadLine());

                if (keyboard == 1)
                {
                    Question1.Q1();
                }
                else if (keyboard == 2)
                {
                    Question2.sign();
                }
            } while (keyboard < 3);
            Console.ReadLine();

        }
    }
}
