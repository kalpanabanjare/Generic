using System;
namespace Generic
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find maximum");
            int intOutput = MaxNumCheck.MaximunIntegerNumber(22, 66, 99);
            Console.WriteLine(intOutput);
            float floatOutput = MaxNumCheck.MaximunFloatNumber(229.78f, 112.96f, 96.9f);
            Console.WriteLine(floatOutput);
            string stringOutput = MaxNumCheck.MaximunString("Mango", "Pineapple", "Banama");
            Console.WriteLine(stringOutput);
        }
    } 
}    