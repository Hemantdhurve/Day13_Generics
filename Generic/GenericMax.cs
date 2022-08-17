using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class GenericMax<T> where T : IComparable
    {
        public T[] value;

        //constructor of class 
        public GenericMax(T[] value)
        {
            this.value = value;
        }


        public T[] SortValue(T[] value)
        {
            Array.Sort(value);
            return value;
        }


        public T FindMax(T[] values)
        {
            var sortedValues = SortValue(this.value);
            return sortedValues[sortedValues.Length - 1];
        }

        public T FindMaxMethod()
        {
            var maxValue = FindMax(this.value);
            return maxValue;
        }
        // Creating Print Method..
        public void PrintMax()
        {
            var MaxValue = FindMax(this.value);
            Console.WriteLine("Maximum value = " + MaxValue);
        }
    }      
}
