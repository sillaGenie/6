using System;
using System.Collections.Generic;
using System.Linq;
namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            string startstring = Console.ReadLine();
            string[] stringArray = startstring.Split();
            int [] vs = new int[stringArray.Length];
            int max = -1;
            int index = -1;
            for (int i = 0; i < stringArray.Length; i++)
            {
                vs[i] = stringArray[i].Length;
            }
            for (int i = 0; i < vs.Length; i++)
                if (max <= vs[i])
                {
                    max = vs[i];
                    index = i;
                }
            Console.WriteLine(stringArray[index]);   
            Console.ReadKey();
        }
    }
}