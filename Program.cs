using System.Diagnostics;

namespace DataTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple :");
            int apples = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total price of " + apples + " apple(s) : " );
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of " + apples + " apple(s) :" + price);

            int converted_price = (int)price;
            Console.WriteLine("The value of original price is : " + price);
            Console.WriteLine("The value of converted price is :" + converted_price);
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}