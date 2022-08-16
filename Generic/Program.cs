using System;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Program");

            bool check = true;

           
            while (check)
            {
                Console.Write("Select Option:\n" +
                   "1)Find Integer Maximum Number\n" +
                   "2)Find Float Maximum Number\n" +
                   "3)FInd Maximum String \n");


                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {


                    case 1:

                        FindMax<int> obj = new FindMax<int>(23, 50, 5);
                        int result = obj.MaxFind();

                        Console.WriteLine(result);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Greatest number among three numbers is :" + result);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 2:
                        
                        FindMax<float> obj1 = new FindMax<float>(11.5f, 100.5f, 3.5f);
                        float result1 = obj1.MaxFind();

                        Console.WriteLine(result1);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Greatest Float number among three numbers is :" + result1);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 3:
                       
                        //we get output on the basis of ASCII Vlue
                        FindMax<string> obj2 = new FindMax<string>("a", "b", "c");
                        string result2 = obj2.MaxFind();


                        Console.WriteLine(result2);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Greatest String among three numbers is :" + result2);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                        break;
                    default:
                        check = !check;
                        break;
                }
            }

        }
    }
}