using System;

namespace UPPGIFT_3___GR_NT_KORT
{
    class Program
    {
        static void Main(string[] args)
        {
            const int singleClimbTime = 10;


            Console.WriteLine("Hur många klättrare har grönt kort?");
            int greenClimbers = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många klättrare har inte grönt kort?");
            int normalClimbers = int.Parse(Console.ReadLine());

            int amountOfClimbs = 0;

            amountOfClimbs += 2 + (greenClimbers % 2);
            amountOfClimbs += (int)Math.Ceiling((float)normalClimbers / greenClimbers);

            int climbTime = singleClimbTime * amountOfClimbs;

            Console.WriteLine("Det kommer ta: " + climbTime + " minuter att klättra");
        }
    }
}
