using System;
namespace Generic
{
    class program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("Welcome in Generic Method");
                Console.WriteLine("to find max");
                MaxGeneric<int> generInt = new MaxGeneric<int>();
                generInt.Maximum(27, 88, 45);

                MaxGeneric<float> genericFloat = new MaxGeneric<float>();
                genericFloat.Maximum(66.2f, 55.5f, 34.8f);

                MaxGeneric<string> genericString = new MaxGeneric<string>();
                genericString.Maximum("Apple", "Peach", "Banana");
        }
    } 
}    