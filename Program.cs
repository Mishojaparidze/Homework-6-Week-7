using System;
using System.Collections.Generic;

namespace Homework_6_Week_7
{
    internal class Program
    {
        static void Main()
        {
            #region SolutionN1

            Console.WriteLine("SolutionN1");
            Console.WriteLine("Enter Radius Of Circle");
            int radius= Convert.ToInt32(Console.ReadLine());
            /* In first square, diameter of the circle equals a side of a square  a=2r
             * area of the big square equals  S1=a^2=4r^2
             * let's split small square into 2 equal triangle.
             * we have a triangle with one angle of 90 degree, which is giving us an opportunity to count one side of the small square
             * b^2+b^2=(2r)^2  with pythagoras theorem. so from this we can count second square's area which will be S2=b^2
             * which is = 2r^2
             * so S1-S2= 4r^2-2r^2= 2r^2
             */
            Console.WriteLine(2*radius*radius);

            #endregion

            #region SolutionN2
            Console.WriteLine("SolutionN2");
            Console.WriteLine("Enter how many characters you want to enter: ");

            int counter = 0;
            var n = int.Parse(Console.ReadLine());
            char[] firstArray = new char[n];
            Console.WriteLine("Enter Characters");
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                if (firstArray[0] == firstArray[i + 1])
                {
                    counter++;
                }  
            }
            if (counter==n-1)
            {
                Console.WriteLine("Yes!!!");
            }
            else
            {
                Console.WriteLine("No!!!");
            }

            #endregion

            #region SolutionN3
            Console.WriteLine("SolutionN3");
            Console.WriteLine("Enter the results");
            int[] array=new int[3];
            for (int i = 0; i < 3; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine ());
            }
            int result = array[0] * 3 + array[1];
            Console.WriteLine($"result: {result}");


            #endregion

            #region SolutionN4
            Console.WriteLine("SolutionN4");
            Console.WriteLine("Enter the hours of the work:");
            int[] arrayWorkHours = new int[7];
            int salary = 0;
            for (int i = 0; i < 7; i++)
            { 
                arrayWorkHours[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (arrayWorkHours[i] <= 8)
                {
                    salary += arrayWorkHours[i] * 10;
                }
                else{
                    salary += arrayWorkHours[i] * 15;
                }
                
            }
            
            if (arrayWorkHours[5] > 0) 
            {
                if (arrayWorkHours[5]>8)
                {
                    salary += (arrayWorkHours[5] - 8) * 30 + arrayWorkHours[5] * 20;
                }
                else
                {
                    salary += arrayWorkHours[5] * 20;
                }
            }
            if (arrayWorkHours[6] > 0)
            {
                if (arrayWorkHours[6] > 8)
                {
                    salary += (arrayWorkHours[6] - 8) * 30 + arrayWorkHours[6] * 20;
                }
                else
                {
                    salary += arrayWorkHours[6] * 20;
                }
            }


            Console.WriteLine(salary);



            #endregion

            #region SolutionN5

            Console.WriteLine("SolutionN5 ");
            Console.WriteLine("Enter the hours of work for 5 days:");
            int[] arrayWourkoutHour = new int[5];
            int k=0;
            for (int i = 0; i < 5; i++)
            {
                arrayWourkoutHour[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < arrayWourkoutHour.Length-1; i++)
            {
                if (arrayWourkoutHour[i] < arrayWourkoutHour[i+1])
                {
                    k++;
                }
            }
            Console.WriteLine(k);


            #endregion

            #region SolutionN6

            Console.WriteLine("SolutionN6");
            Console.WriteLine("Enter how many words you want to enter:");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter words:");

            List <string> myList = new List <string>();
            for (int i = 0; i < j; i++)
            {
                myList.Add(Console.ReadLine());
            }
            Console.WriteLine("Enter searching length of words:");
            int t = Convert.ToInt32(Console.ReadLine());
            foreach (var item in myList)
            {
                if (item.Length>t)
                {
                    Console.WriteLine(item);
                }
            }


            #endregion

        }
    }
}
