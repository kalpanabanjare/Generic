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
            double floatOutput = MaxNumCheck.MaximunFloatNumber(229.78, 112.96, 96.9);
            Console.WriteLine(floatOutput);
        }
    } 
}    