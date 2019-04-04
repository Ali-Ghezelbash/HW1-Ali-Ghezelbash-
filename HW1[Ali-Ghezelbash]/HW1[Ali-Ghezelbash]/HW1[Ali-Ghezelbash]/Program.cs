using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Ali_Ghezelbash_
{
    class Program5

    {
        static void Main(string[] args)
        {

            string number0 , number1, number2, number3, number4, number5, number6, number7, number8, number9;
            int [] num = new int [10] ;
            int max = 0;

            Console.Write("Please Enter The First Integer :");
            number0 = Console.ReadLine();

            Console.Write("Please Enter The Second Integer :");
            number1 = Console.ReadLine();

            Console.Write("Please Enter The Third Integer :");
            number2 = Console.ReadLine();

            Console.Write("Please Enter The Fourth Integer :");
            number3 = Console.ReadLine();

            Console.Write("Please Enter The Fifth Integer :");
            number4 = Console.ReadLine();

            Console.Write("Please Enter The Sixth Integer :");
            number5 = Console.ReadLine();

            Console.Write("Please Enter The Seventh Integer :");
            number6 = Console.ReadLine();

            Console.Write("Please Enter The Eighth Integer :");
            number7 = Console.ReadLine();

            Console.Write("Please Enter The Ninth Integer :");
            number8 = Console.ReadLine();

            Console.Write("Please Enter The Tenth Integer :");
            number9 = Console.ReadLine();

                num[0] = Int32.Parse(number0);
            num[1] = Int32.Parse(number1);
            num[2] = Int32.Parse(number2);
            num[3] = Int32.Parse(number3);
            num[4] = Int32.Parse(number4);
            num[5] = Int32.Parse(number5);
            num[6] = Int32.Parse(number6);
            num[7] = Int32.Parse(number7);
            num[8] = Int32.Parse(number8);
            num[9] = Int32.Parse(number9);

            for (int j = 0; j < 10; j++)
            {
                if (num[j] == null)
                    num[j] = 0;
            }

            for (int i = 0; i < 10; i++)
                {
                    if (num[i] > max)
                        max = num[i];
                }

            Console.WriteLine("The largest number : " + max);
            Console.ReadKey();

        }
    }
}
