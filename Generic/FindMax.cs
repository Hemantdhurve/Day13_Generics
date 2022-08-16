using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class FindMax<T>
    {
        //declaring variables of generic type
        public T first,second,third;

        public FindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        //using Generics Method to Refactor
        //Using placeholder T in generic Method we can reuse our code 
        public T MaxFind<T>(T first, T second, T third) where T:IComparable
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            return default;
        }
       
    }
}
