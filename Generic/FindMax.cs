using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class FindMax<T> where T : IComparable
    {
        //declaring variables of generic type
        public T first,second,third,forth;

        //parameterize constructor of class

        //In UC4 entend MaxFind method to take more than 3 parameters
        public FindMax(T first, T second, T third,T forth)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.forth = forth;
        }

        //using Generics Method to Refactor
        //Using placeholder T in generic Method we can reuse our code 
            
        public T MaxFind()
        {

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 && first.CompareTo(forth) >0 )
            {
                return first;
            }

            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 && second.CompareTo(forth) >0 )
            {
                return second;
            }

            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 && third.CompareTo(forth) >0 )
            {
                return third;
            }

            if (forth.CompareTo(first) > 0 && forth.CompareTo(second) > 0 && forth.CompareTo(third) > 0)
            {
                return forth;
            }

                return default;
        }
       
    }
}
