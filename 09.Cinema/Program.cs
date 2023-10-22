namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Reads the type of the movie(string), the count of the rows(an integer number) and 
                //                count of the seats per row(an integer number) in the cinema
                //Type of the movie will be one of the following: "Premiere", "Normal" and "Discount"
                //Prints the total price for all seats formatted to the 2nd digit after the decimal point, based on the table below:


            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            if (movieType == "Premiere")
            {
                double price = rows * seats * 12.00;
                Console.WriteLine($"{price:f2}");
            }
            else if (movieType == "Normal") 
            {
                double price = rows * seats * 7.50;
                Console.WriteLine($"{price:f2}");
            }
            else if (movieType == "Discount")
            {
                double price = rows * seats * 5.00;
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}