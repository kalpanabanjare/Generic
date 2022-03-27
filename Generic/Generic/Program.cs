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
                generInt.Maximum(34, 89, 76);

                MaxGeneric<float> genericFloat = new MaxGeneric<float>();
                genericFloat.Maximum(69.2f, 85.5f, 93.8f);

                MaxGeneric<string> genericString = new MaxGeneric<string>();
                genericString.Maximum("pineapple", "Peach", "Banana");
        }
    } 
}    