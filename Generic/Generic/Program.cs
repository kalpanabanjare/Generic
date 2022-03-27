using System;
namespace Generic
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Generic Method");
            Console.WriteLine("To find maximum value");
            MaxGeneric<int> maxGenericInt = new MaxGeneric<int>(33, 66, 99);
            maxGenericInt.Maximum();

            MaxGeneric<float> maxGenericFloat = new MaxGeneric<float>(98.7f, 33.33f, 56.87f);
            maxGenericFloat.Maximum();

            MaxGeneric<string> maxGenericString = new MaxGeneric<string>("PineApple", "Peach", "Banana");
            maxGenericString.Maximum();
        }
    }
}
            