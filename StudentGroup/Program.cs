using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new console application called StudentGroup
            //Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
            //Get a number from the console between 1 and 2 and print the students from that group in the console.
            string[] studentsG1 = { "Sonja", "Filip", "Trajce", "Gjorgji", "Veronika" };
            string[] studentsG2 = { "Elena", "Martina", "Jovana", "Vladimir", "Aleksandar" };

            int whichGroup;
            Console.WriteLine("Choose one group: 1 or 2?");
            whichGroup = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (whichGroup == 1)
                {
                    Console.WriteLine("The students are:" + studentsG1[i]);
                }
                else if (whichGroup == 2)
                {
                    Console.WriteLine("The students are:" + studentsG2[i]);
                }
            }
        }
    }
}
