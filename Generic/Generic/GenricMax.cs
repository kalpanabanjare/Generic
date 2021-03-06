using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class MaxGeneric<T> where T : IComparable
    {
        public T valueOne;
        public T valueTwo;
        public T valueThree;
        public MaxGeneric(T valueOne, T valueTwo, T valueThree)
        {
            this.valueOne = valueOne;
            this.valueTwo = valueTwo;
            this.valueThree = valueThree;
        }
        public void Maximum()
        {
            T maxValue = valueOne;
            if (valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) > 0)
            {
                maxValue = valueOne;
                Console.WriteLine("Maximum Value is: " + maxValue);
            }
            else if (valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) > 0)
            {
                maxValue = valueTwo;
                Console.WriteLine("Maximum Value is: " + maxValue);
            }
            else if (valueThree.CompareTo(valueOne) > 0 && valueThree.CompareTo(valueTwo) > 0)
            {
                maxValue = valueThree;
                Console.WriteLine("Maximum Value is: " + maxValue);
            }
            else
            {
                Console.WriteLine("All value are same");
            }
        }
    }
}