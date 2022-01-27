using System;
using System.Collections.Generic;
using System.Linq;
namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            string String1 = Console.ReadLine();
            string String2 = "";
            String1 = String1.Replace(" ", ""); ;
            Console.WriteLine(String1);
            int result;
            for (int i = 0; i < String1.Length; i++)
            {
                String2 += String1[String1.Length - i - 1];
            }
            Console.WriteLine(String2);
            result = String.Compare(String1, String2,true);
            if (result == 0)
                Console.WriteLine("палиндром");
            else
                Console.WriteLine("не палиндром");
            Console.ReadKey();
        }
    }
}