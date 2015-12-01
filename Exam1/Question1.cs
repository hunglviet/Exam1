using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Question1
    {
        //public static string[] arr1;
        public static void Q1()
        {
            //string[] arr1;
            int n;

            //Create array with n element
            Console.WriteLine("Enter number element array");
            n = Convert.ToInt32(Console.ReadLine());

            string[] arr1 = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter value of element {0}", i + 1);
                arr1[i] = Console.ReadLine();
            }

            //Output array
            Console.WriteLine("Your array");
            foreach (string item in arr1)
            {
                Console.WriteLine("{0} ", item);
            }
            //Modify array
            Console.WriteLine("Enter number element you want modify: ");
            int a = Convert.ToInt32( Console.ReadLine());
            if (a < 0 || a > arr1.Length)
            {
                Console.WriteLine("{0} is out of range in your aray",a-1);
            }
            else
            {
                Console.WriteLine("Enter new value for {0} element",a);
                Console.WriteLine("{0} will be replaced with new content",arr1[a-1]);
                arr1[a-1] = Console.ReadLine();

            }

            //Sort array
            Console.WriteLine("Array after sorted");
            Array.Sort(arr1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            //Console.ReadLine();
        }
    }
}
