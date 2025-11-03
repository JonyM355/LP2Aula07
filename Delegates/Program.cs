using System;

namespace Delegates
{
    public class Program
    {
        private static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        private static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        private static void Main(string[] args)
        {
            Joiner joiner = new Joiner("This is Form Joiner! ");

            Action<string> myDelegate = PrintUpper;
            myDelegate += PrintLower;
            myDelegate += joiner.JoinAndPrint;

            myDelegate.Invoke("Outra String QualQUER");
        }
    }
}
