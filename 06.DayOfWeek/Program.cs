using System.Buffers.Text;
using System.Collections.Generic;

namespace _06.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reads an integer number(the number will be in range[1… 7]) from the console
            //Based on the value of the number, print:
            // If the given number is equals to 1 print the first day of the week, which is "Monday"
            // If the given number is equals to 2 print the second day of the week, which is "Tuesday"
            // If the given number is equals to 3 print the third day of the week, which is "Wednesday"
            // If the given number is equals to 4 print the fourth day of the week, which is "Thursday"
            // If the given number is equals to 5 print the fifth day of the week, which is "Friday"
            // If the given number is equals to 6 print the sixth day of the week, which is "Saturday"
            // If the given number is equals to 7 print the seventh day of the week, which is "Sunday"
            // If the given number is out of the given range print "Error"
            int deyNumber = int.Parse(Console.ReadLine());
            switch (deyNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("Error");
                    break;

            }
        }
    }
}