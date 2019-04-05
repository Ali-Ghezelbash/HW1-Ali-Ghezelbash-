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

            string[] number = new string[10];
            int [] num = new int [10] ;
            int max = 0;

            /*Console.Write("Please Enter The First Integer :");
            number[0] = Int32.Parse(Console.ReadLine());
            
            Console.Write("Please Enter The Second Integer :");
            number[1] = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter The Third Integer :");
            number[2] = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter The Fourth Integer :");
            number[3] = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter The Fifth Integer :");
            number[4] = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter The Sixth Integer :");
            number[5] = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter The Seventh Integer :");
            number[6] = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter The Eighth Integer :");
            number[7] = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter The Ninth Integer :");
            number[8] = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter The Tenth Integer :");
            number[9] = Int32.Parse(Console.ReadLine());*/

            Console.Write("Please Enter The First Integer :");
            number[0] = Console.ReadLine();

            Console.Write("Please Enter The Second Integer :");
            number[1] = Console.ReadLine();

            Console.Write("Please Enter The Third Integer :");
            number[2] = Console.ReadLine();

            Console.Write("Please Enter The Fourth Integer :");
            number[3] = Console.ReadLine();

            Console.Write("Please Enter The Fifth Integer :");
            number[4] = Console.ReadLine();

            Console.Write("Please Enter The Sixth Integer :");
            number[5] = Console.ReadLine();

            Console.Write("Please Enter The Seventh Integer :");
            number[6] = Console.ReadLine();

            Console.Write("Please Enter The Eighth Integer :");
            number[7] = Console.ReadLine();

            Console.Write("Please Enter The Ninth Integer :");
            number[8] = Console.ReadLine();

            Console.Write("Please Enter The Tenth Integer :");
            number[9] = Console.ReadLine();

            for (int j = 0; j < 10; j++)
            {
                if ( number[j] == "")
                    number[j] = "0";
            }

            num[0] = Int32.Parse(number[0]);
            num[1] = Int32.Parse(number[1]);
            num[2] = Int32.Parse(number[2]);
            num[3] = Int32.Parse(number[3]);
            num[4] = Int32.Parse(number[4]);
            num[5] = Int32.Parse(number[5]);
            num[6] = Int32.Parse(number[6]);
            num[7] = Int32.Parse(number[7]);
            num[8] = Int32.Parse(number[8]);
            num[9] = Int32.Parse(number[9]);
            

            for (int i = 0; i < 10; i++)
                {
                    if (num[i] > max)
                        max = num[i];
                }

            Console.WriteLine("The largest number : " + max );
            Console.ReadKey();

            string time;
            DateTime d = DateTime.Now;
            time = "\n Today is " + d.DayOfWeek + "\n date is "
            + d.Year.ToString() + "/" + d.Month.ToString() + "/"
            + d.Day.ToString() + "\n time is " + d.Hour.ToString() + " : " + d.Minute.ToString() + " : " + d.Second.ToString();
            Console.WriteLine(time);
            Console.ReadKey();

        }
    }
}
