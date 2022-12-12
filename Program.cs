using System;

namespace Generic
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum of Numbers program");
            string maxNum = FindMaxNumber.FindMax<string>("Apple", "Banana", "Peach");
            Console.WriteLine(maxNum);

            int maxNumInInt = FindMaxNumber.FindMax<int>(10, 20, 30);
            Console.WriteLine(maxNumInInt);
        }
    }
}