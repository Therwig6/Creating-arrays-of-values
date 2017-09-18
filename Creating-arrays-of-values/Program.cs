using System;

namespace Creatingarraysofvalues
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            // an int array clasification
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 42;

            Console.WriteLine(numbers.Length);

            /*
            int[] numbers = new int[] { 4, 8, 16, 23, 42 };

            Console.WriteLine(numbers[1].ToString());
            Console.WriteLine();
            */
            //This defines the array witout having to list the whole every name

            /*
            string[] names = new string[] { "Eddie", "Alex", "Micheal", "David Lee" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */
            /*
            string zig = "you can get what you want out of life" +
                "if you help pther people get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            //reverses the list

            foreach (char zigChar in charArray)
                Console.Write(zigChar);
            // Console.Write writes on only one line instead of one new for each char
            Console.ReadLine();
            */
            
        }
    }
}