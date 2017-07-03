using static System.Console;
using static LogicS.GreetingClass;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter user name:");
            //string userName = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine(GreetingClass.GreetingMethod(userName));
            //Console.ReadKey();
            Write("Enter user name:");
            string userName = ReadLine();
            Clear();
            WriteLine(GreetingMethod(userName));
            ReadKey();
        }
    }
}
