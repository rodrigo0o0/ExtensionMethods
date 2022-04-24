using ExtensionMethods.Extensions;
using System;


namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime(2022, 04, 23, 8, 10, 45);
            //Console.WriteLine(dt.ElapsedTime());
            string s1 = "GOOD MORNING DEAR STUDENTS! :D :D :D ";

            Console.WriteLine(s1.Cut(10));

            Console.ReadKey();
        }
    }
}
