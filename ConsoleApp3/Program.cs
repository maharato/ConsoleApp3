using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "welcome to MAHARATO's Carpet Cleaning Service" +
                "\n our charges is" +
                "$25 per small\r\n  " +
                "$35 per large\r\n   " +
                "Sales tax rate is 6%\r\n  " +
                "Estimates are valid for 30 days");
            Console.WriteLine("please enter number of your small carpets");
            int small = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("please enter number of your large carpets");
            int large = Convert.ToInt32(Console.ReadLine());
            int total=(small*25)+(large*35);
            int tax = total*6/100;
            Console.WriteLine($"Number of small carpets: {small} \r\nNumber of large carpets: {large} \r\nPrice for small carpets: ${small*25}\r\nPrice for large carpets: ${large*35}\r\nCost : ${total}\r\nTax: ${tax}\r\n===============================\r\nTotal estimate: ${tax+total}\r\nThis estimate is valid for 30 days");     }
    }
}
