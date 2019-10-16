using System;

namespace Open_Lab_03._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[,]
            {
                {"cat", "dog", "fish"},
                {"bird", "elephant", "frog"},
            };

            Console.WriteLine(array[1, 2]);
        }
    }
}
