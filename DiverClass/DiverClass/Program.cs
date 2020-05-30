using System;

namespace DiverClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDivers = 0;
            string fileName = "";

            fileName = Console.ReadLine();
            DiverClass class1 = new DiverClass(fileName);

            class1.FillArray(fileName);

            class1.Sort();

            class1.PrintArray();

            numDivers = class1.CountDivers();

            Console.WriteLine("There are " + numDivers + " divers.");

            Console.WriteLine(class1.CalculateDive(3, 21));
            Console.WriteLine(class1.totalScore(20));
        }


    }
}
