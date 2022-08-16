using System;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Program");

            bool check = true;
            FindMax obj = new FindMax();


            while (check)
            {
                Console.Write("Select Option:\n" +
                   "1)Find Integer Maximum Number\n" +
                   "2)Find Float Maximum Number\n");


                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {


                    case 1:
                        int result = obj.FindMaxInteger(23, 50, 5);

                        Console.WriteLine(result);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Greatest number among three numbers is :" + result);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 2:
                        float result1 = obj.FindMaxInteger(11.5f, 100.5f, 3.5f);

                        Console.WriteLine(result1);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Greatest Float number among three numbers is :" + result1);
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