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
                   "1)Find Integer Maximum Number\n");
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
                    default:
                        check = !check;
                        break;
                }
            }

        }
    }
}