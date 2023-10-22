namespace _08SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reads 3 integer numbers from the console
            //Based on the order of the numbers, print:
            //"Ascending" – if the numbers are in ascending order(from the smallest to the largest number)
            //"Descending" – if the numbers are in descending order(from the largest to the smallest number)
            //"Not sorted" – in any other case
            //Note:  Given numbers will not be equal.
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1  >num2 && num2 > num3)
            {
                Console.WriteLine("Descending");
            }
            else if (num1 <num2 && num2 < num3)
            {
                Console.WriteLine("Ascending");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
        }
}