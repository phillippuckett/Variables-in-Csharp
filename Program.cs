using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            
            Console.WriteLine("What is your name?");
            Console.Write("Type in your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            Console.Write("Type your last name: ");
            //string myLastName;
            //myLastName = Console.ReadLine();
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);

            // TIP: If you need to rename all occurences of a variable, use hotkey [CTRL + .]
            // TIP: C# is a case sensitive language, utilizing camelCase helps visually
            // TIP: if you have two variables that have the same, reconsider renaming one of them
        }
    }
}
https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners/Understanding-Data-Types-and-Variables