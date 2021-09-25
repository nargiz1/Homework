using System;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Tapsiriq1(int n, params int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==n)
                {
                    count++;
                }
                
            }
            if (count > 0)
            {
                Console.WriteLine("Yes");
            }
            else if (count <= 0)
            {
                Console.WriteLine("No");
            }


        }

        static int Tapsiriq2(params int[] arr)
        {
            int i = arr.Length - 1;
            Array.Sort(arr);
            return arr[i];
        }
    }
}
