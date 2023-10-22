using System.Threading;

namespace _04.FoodOrDrink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            //Reads a product(string) from the console
            //Based on type of the given product, print:
            //If product is one of following "curry", "noodles", "sushi", "spaghetti" or "bread" you have to print "food"
            //If product is one of following "tea", "water", "coffee" or "juice" you have to print "drink"
            //If the product is different from listed products above, print "unknown"
            if(product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
            {
                Console.WriteLine("food");
            }
            else if (product == "tea" || product == "water" || product == "coffee" || product == "juice")
            {
                Console.WriteLine("drink");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}