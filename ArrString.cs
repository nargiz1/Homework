using System;

namespace ArrString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add text:");
            string txt = Console.ReadLine();
            Split(txt);

        }

        static void Split(string sentence1)
        {
            string[] result1 = sentence1.Split(' ');

            string result2 = string.Empty;
            for(int i=result1.Length-1; i>=0; i--)
            {
                result2 += result1[i]+" ";
            }

            string result = string.Empty;
            for (int i = result2.Length - 1; i >= 0; i--)
            {
                result += result2[i];
            }
            Console.WriteLine($"Reversed: {result}");
        }
    }
}
