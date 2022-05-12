using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_6_Week_7
{
    internal class Program
    {
        static void GetGenericValue<T>(List<T> someList)
        {
            int k=0;
           bool isNumber=int.TryParse(someList[0].ToString(), out var number);
            if (isNumber)
            {
                for (int i = 0; i < someList.Count; i++)
                {
                    
                }
            }
        }
        static string Recursion(string number)
        {
            foreach (var item in number)
            {
                Console.WriteLine(item); 
            }
            return number;
        }
        static string FindLongestCommonSubstring(string s1, string s2)
        {
            int[,] a = new int[s1.Length + 1, s2.Length + 1];
            int row = 0;    // s1 string index
            int col = 0;    // s2 string index

            for (var i = 0; i < s1.Length; i++)
                for (var j = 0; j < s2.Length; j++)
                    if (s1[i] == s2[j])
                    {
                        int len = a[i + 1, j + 1] = a[i, j] + 1; // increasing length of common substring if next char is on both string same
                        if (len > a[row, col])
                        {
                            row = i + 1;
                            col = j + 1;
                        }
                    }

            return s1.Substring(row - a[row, col], a[row, col]); // returning the same common substring from the 2 string
        }
        static void Numbers1 (int a, int b, int n) 
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < b/2; i++)
            {
                numbers.Add(i);
            }
            foreach (int item in numbers)
            {
                if (Math.Pow(item,n)>=a && Math.Pow(item,n)<b)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void Main()
        {
            #region SolutionN1

            Console.WriteLine("Solution N1 \n");
            Console.WriteLine("Enter minimum");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maximum");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            Numbers1(a, b, n);

            #endregion

            #region SolutionN2


            Console.WriteLine("Solution N2 \n");
            Console.WriteLine("Enter word: ");
            string word=Console.ReadLine();
            var chars=word.ToCharArray();
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            foreach (var ch in chars)
            {
                if (charDictionary.ContainsKey(ch))
                {
                    charDictionary[ch] = charDictionary[ch]+1;
                }
                else
                {
                    charDictionary.Add(ch, 1);
                }
            }
            var keys = new HashSet<char>(charDictionary.Keys);
            foreach (var ch in keys)
            {
                if (charDictionary[ch]>0)
                {
                    Console.WriteLine($"{charDictionary[ch]/2} pair of socks+");
                   
                }
            }

            #endregion

            #region SolutionN3
            Console.WriteLine("Solutiion N3\n");

            Console.WriteLine("enter first word");
            string word1 = Console.ReadLine();
            Console.WriteLine("enter second word");
            string word2 = Console.ReadLine();

            Console.WriteLine(FindLongestCommonSubstring(word1,word2));

            #endregion

            #region SolutionN4

            Console.WriteLine("Solutiion N4\n");
            Console.WriteLine("Enter string int or bool");
            List<string> words = new List<string>();
            List<int> numbers = new List<int>();
            List<bool> bools = new List<bool>();
       
            #endregion

            #region SolutionN5

            Console.WriteLine("Solution N5 \n");
            Console.WriteLine("Enter your number");
            string numberFromConsole = Console.ReadLine();

            Console.WriteLine(Recursion(numberFromConsole));

            #endregion
        }
    }
}
